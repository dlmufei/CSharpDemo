using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sharp_event_delegate
{
    public partial class Form1 : Form
    {

        DataProvider dataProvider = null;

        //3、第三种方式 BackgroundWorker
        private BackgroundWorker backgroundWorker1 = null;

        public Form1()
        {
            InitializeComponent();


            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            //设置报告进度更新
            backgroundWorker1.WorkerReportsProgress = true;
            //注册线程主体方法
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            //注册更新UI方法
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);

        }

        private void btnStartDataProvider_Click(object sender, EventArgs e)
        {
            dataProvider = new DataProvider();
            dataProvider.Refresh += refreshMethod01;
            dataProvider.getData();

        }

        private void refreshMethod01(int index)
        {
            MessageBox.Show("Data: "+index);
        }

        private void refreshMethod02(int index)
        {
            Console.WriteLine("Data: " + index);
        }

        /// <summary>
        /// 第一种实现跨线程更新UI的方法
        /// </summary>
        /// <param name="index"></param>
        private void refreshMethod03(int index)
        {
            //Control静态类变量，改变以后全局改变
            Control.CheckForIllegalCrossThreadCalls = false;
            txtDisplay.Text = "Data: " + index;
        }

        /// <summary>
        /// 第二种实现跨线程更新UI的方法
        /// </summary>
        /// <param name="index"></param>
        private void refreshMethod04(int index)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DataProvider.RefreshHandler(refreshMethod04), new object[] { index });
            }
            else 
            {
                txtDisplay.Text = "Data: " + index;
            } 
        }

        private void btnDataThread_Click(object sender, EventArgs e)
        {            
            dataProvider = new DataProvider(1);
            dataProvider.Refresh += refreshMethod04;
        }

        /*------------------------------------------------------------------------------*/
        //第二步：定义执行线程主体事件
        //线程主体方法
        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //...执行线程任务

            //在线程中更新UI（通过ReportProgress方法）
            backgroundWorker1.ReportProgress(50, "This text was set safely by BackgroundWorker.");

            //...执行线程其他任务
        }
        //第三步：定义执行UI更新事件
        //UI更新方法
        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.txtDisplay.Text = e.UserState.ToString();
        }


    }
}
