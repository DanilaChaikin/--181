using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace Company
{
    public partial class Form1 : Form
    {
        private Machine _auto;
        private Miller[] _millers;
        private Loader _loader;
        private ManualResetEvent pogrNew1;
        private ManualResetEvent pogrReady;
        private ManualResetEvent evToLoaderpogr;
        private ManualResetEvent MachineWork;

        private static Semaphore _pool;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.Image1;
            pictureBox2.Image = Properties.Resources.Image4;
            pictureBox3.Image = Properties.Resources.Image6;
            item.Image = Properties.Resources.Image5;
            CheckForIllegalCrossThreadCalls = false;
            pogrNew1 = new ManualResetEvent(false);
            pogrReady = new ManualResetEvent(false);
            MachineWork = new ManualResetEvent(false);
            evToLoaderpogr = new ManualResetEvent(false);
            _pool = new Semaphore(1, 1);
            _millers = new Miller[1];
            _millers[0] = new Miller(ref people1, _pool, pogrNew1, pogrReady, MachineWork, evToLoaderpogr);
            _auto = new Machine(ref statusMachine, ref item, MachineWork, pogrReady);
            _loader = new Loader(ref loader, evToLoaderpogr);
        }

        private void newItem(object sender, EventArgs e)
        {
            Button PushButtom = sender as Button;
            switch (PushButtom.Text)
            {
                case "Создать деталь":
                    pogrNew1.Set();
                    break;
                default:
                    return;
            }
        }
    }
    interface ILoader
    {
        void receivedItem();
        void loadedItem();
    }

    class Miller
    {
        public Thread Thrd;
        ManualResetEvent ItemNew;
        ManualResetEvent ItemReady;
        ManualResetEvent MachineWork;
        ManualResetEvent ItemToLoader;

        private Semaphore MachineIsBusy;
        private Label text;

        public Miller(ref Label field,
                        Semaphore MachineIsBusy,
                        ManualResetEvent ItemNew,
                        ManualResetEvent ItemReady,
                        ManualResetEvent MachineWork,
                        ManualResetEvent ItemToLoader)
        {
            text = field;
            this.MachineIsBusy = MachineIsBusy;
            this.ItemNew = ItemNew;
            this.ItemReady = ItemReady;
            this.MachineWork = MachineWork;
            this.ItemToLoader = ItemToLoader;

            Thrd = new Thread(Run);
            Thrd.Start();
        }

        void Run()
        {
            while (true)
            {
                text.Text = "Свободен";
                ItemNew.WaitOne();
                MachineIsBusy.WaitOne();
                text.Text = "Деталь принял в работу";
                MachineWork.Set();
                ItemReady.WaitOne();
                text.Text = "Деталь готова";
                ItemNew.Reset();
                ItemReady.Reset();
                MachineIsBusy.Release();
                ItemToLoader.Set();
            }
        }
    }

    class Loader : ILoader
    {
        public Thread Thrd;
        public ManualResetEvent evToLoader;
        public Label text;

        public Loader(ref Label field, ManualResetEvent evToLoader)
        {
            Thrd = new Thread(this.Run);
            this.evToLoader = evToLoader;
            text = field;
            Thrd.Start();
        }

        public void Run()
        {
            while (true)
            {
                evToLoader.WaitOne();
                receivedItem();
                Thread.Sleep(1000);
                loadedItem();
                evToLoader.Reset();
            }
        }

        public void receivedItem()
        {
            text.Text = "Погрузка детали";
        }

        public void loadedItem()
        {
            text.Text = "Деталь отгружена";
        }
    }
    class Machine
    {
        public Thread Thrd;
        public ManualResetEvent MachineIsBusy;
        public ManualResetEvent ItemReady;
        public Label text;
        public PictureBox Thing;

        public Machine(ref Label field, ref PictureBox Thing, ManualResetEvent MachineIsBusy, ManualResetEvent ItemReady)
        {
            Thrd = new Thread(Run);
            this.MachineIsBusy = MachineIsBusy;
            this.ItemReady = ItemReady;
            this.Thing = Thing;
            text = field;
            Thrd.Start();
        }

        public void Run()
        {
            while (true)
            {

                MachineIsBusy.WaitOne();
                int start = 210;
                int end = 400;
                int Y = 81;
                int X = start;
                int step = 1;
                Thing.Location = new Point(210, 81);
                text.Text = "Станок изготавливает деталь";
                Thread.Sleep(5000);
                text.Text = "Деталь готова";

                while (X < end)
                {
                    Thing.Location = new Point(X, Y);
                    X += step;
                    Thread.Sleep(5);
                }
                MachineIsBusy.Reset();
                ItemReady.Set();
            }
        }
    }
}
