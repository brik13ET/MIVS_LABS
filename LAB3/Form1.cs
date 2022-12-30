using System;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        DoubleLinkedList<Event1> signal = new DoubleLinkedList<Event1>();
        DoubleLinkedList<Event2> notice = new DoubleLinkedList<Event2>();
        Random random;

        private string[] subj = new string[4];
        private int[] status = new int[4];
        private int[] notification = new int[4] {1,1,1,1};
        private int[] a = new int[4];
        private int[] b = new int[4];
        private int[] moment = new int[4];

        public Form1()
        {
            InitializeComponent();
        }
        public void Signals()
        {
            var p = signal.head.Next;
            while (p != signal.head)
            {
                var arr = new string[3];
                arr[0] = p.Val.getName();
                arr[1] = p.Val.getStatus().ToString();
                arr[2] = p.Val.getNotification().ToString();
                listViewEvent.Items.Add(new ListViewItem(arr));
                p = p.Next;
            }
        }
        public void Notifications()
        {
            var q = notice.head.Next;
            while (q != notice.head)
            { 
                var arr = new string[4];
                arr[0] = q.Val.getName();
                arr[1] = q.Val.getStat().ToString();
                arr[2] = q.Val.getTime().ToString();
                arr[3] = q.Val.Moment().ToString();
                listView.Items.Add(new ListViewItem(arr));
                q = q.Next;
            }
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if ((notification[0] == 0) && (notification[1] == 0) && (notification[2] == 0) && (notification[3] == 0))
            {
                listView.Items.Clear();
                listViewEvent.Items.Clear();
                signal.Clear();
                notice.Clear();
                for (int i = 0; i < 4; i++)
                {
                    a[i] = 0;
                    b[i] = 0;
                    moment[i] = 0;
                }
            }

            subj[0] = "ООП";
            subj[1] = "Ассемблер";
            subj[2] = "Комп. сети";
            subj[3] = "OS";

            random = new Random();
            int moments = 0;

            for (int i = 0; i < 4; i++)
            {
                status[i] = random.Next(0, 2);
                notification[i] = random.Next(0, 2);
                Event1 evi = new Event1(subj[i], status[i], notification[i]);
                signal.Insert(evi);


                b[i] = b[i] + status[i];
                a[i] = a[i] + notification[i];
                moment[i] = b[i] + a[i];

                moments += moment[i];

                var v = new Event2(subj[i], b[i], a[i], moment[i]);
                notice.Insert(v);
            }

            Sum.Text = "Время моделирования: " + moments.ToString();

            listViewEvent.Items.Clear();
            listView.Items.Clear();

            Signals();
            Notifications();

            pictureBoxYellow.Visible = status[0] == 1;
            label1.Visible = status[0] == 1;

            pictureBoxBlue.Visible = status[1] == 1;
            label2.Visible = status[1] == 1;

            pictureBoxGreen.Visible = status[2] == 1;
            label7.Visible = status[2] == 1;

            pictureBoxBlack.Visible = status[3] == 1;
            label8.Visible = status[3] == 1;

            if ((notification[0] == 0) && (notification[1] == 0) && (notification[2] == 0) && (notification[3] == 0))
            {
                MessageBox.Show("Все уведомления обработаны!");
            }
        }
    }
}
