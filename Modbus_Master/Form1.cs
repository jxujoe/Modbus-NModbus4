using Modbus.Device;
using System;
using System.Data;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Modbus_Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_FunCode.SelectedIndex = 0;
            txt_ip.Text = "127.0.0.1";
            txt_port.Text = "502";
            textBox_SlaveID.Text = "1";
            textBox_startAddress.Text = "0";
            textBox_numInputs.Text = "10";


            btn_connect.PerformClick();
        }
        ModbusIpMaster master;
        ushort startAddress = 0;
        ushort numInputs = 10;
        byte slaveID = 1;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            Error(false);
            try
            {
                TcpClient client = new TcpClient(txt_ip.Text.Trim().ToString(), int.Parse(txt_port.Text.Trim().ToString()));
                client.SendTimeout = 1;
                master = ModbusIpMaster.CreateIp(client);
                if (master != null)
                {
                    toolStripLabel_meg.Text = $"{txt_ip.Text}:{txt_port.Text}连接成功！";
                    toolStripLabel2.Image = global::Modbus_Master.Properties.Resources.连接成功;
                }

                btn_disconnect.Enabled = true;
                btn_connect.Enabled = false;
            }
            catch (Exception eee)
            {
                Error(true, eee);
            }
        }


        private void btn_disconnect_Click(object sender, EventArgs e)
        {

            master.Dispose();

            if (master.Transport == null)
            {
                toolStripLabel_meg.Text = $"{txt_ip.Text}：{txt_port.Text}连接已断开！";
                toolStripLabel2.Image = global::Modbus_Master.Properties.Resources.连接断开;
            }
            btn_disconnect.Enabled = false ;
            btn_connect.Enabled = true;
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {


            DataTable dt = new DataTable();
            dt.Columns.Add("地址", typeof(int));
            dt.Columns.Add("值", typeof(ushort));



            ushort[] datas = ModbusRead();
            if (datas != null)
            {
                for (int i = 0; i < datas.Length; i++)
                {

                    dt.Rows.Add(new object[] { i + startAddress, datas[i] });

                }
            }

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = false;
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {

        }


        private ushort[] ModbusRead()
        {
            Error(false);
            try
            {
                startAddress = ushort.Parse(textBox_startAddress.Text);
                numInputs = ushort.Parse(textBox_numInputs.Text);
                slaveID = byte.Parse(textBox_SlaveID.Text);
                ushort[] datas = new ushort[numInputs];
               

                switch (comboBox_FunCode.SelectedIndex)
                {
                    case 0:
                        bool[] coils = master.ReadCoils(slaveID, startAddress, numInputs);
                        for (int i = 0; i < numInputs; i++)
                        {
                            datas[i] = (ushort)(coils[i] ? 1 : 0);
                        }

                        break;
                    case 1:

                        bool[] inputs = master.ReadInputs(slaveID, startAddress, numInputs);
                        for (int i = 0; i < numInputs; i++)
                        {
                            datas[i] = (ushort)(inputs[i] ? 1 : 0);
                        }
                        break;
                    case 2:
                        ushort[] holdingRegisters = master.ReadHoldingRegisters(slaveID, startAddress, numInputs);
                        datas = holdingRegisters;
                        break;
                    case 3:
                        ushort[] inputRegisters = master.ReadInputRegisters(slaveID, startAddress, numInputs);
                        datas = inputRegisters;
                        break;
                    default:
                        MessageBox.Show("功能码错误");
                        datas = null;
                        break;
                }
                txt_show.AppendText("\r\nModbusRead Success");
                return datas;
            }
            catch (Exception eee)
            {
                Error(true, eee);
                return null;
            }
        }



        private void Error(bool IsError, Exception eee = null)
        {
            if (!IsError)
            {
                toolStripLabel_errImage.Image = null;
                toolStripLabel_err.Text = null;
            }
            else
            {
                toolStripLabel_errImage.Image = global::Modbus_Master.Properties.Resources.连接失败;
                toolStripLabel_err.Text = eee.Message;
            }
        }

        private void Error(string eee = null)
        {

            toolStripLabel_errImage.Image = global::Modbus_Master.Properties.Resources.连接失败;
            toolStripLabel_err.Text = eee;

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Error(e.RowIndex + "-" + e.ColumnIndex  );
            ushort Address = ushort.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString());
            ushort Value = ushort.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            ModbusWrite(Address, Value);



        }


        private void ModbusWrite(ushort Address, ushort Value)
        {
            Error(false);
            try
            {
               
                slaveID = byte.Parse(textBox_SlaveID.Text);
                ushort[] datas = new ushort[numInputs];
               

                switch (comboBox_FunCode.SelectedIndex)
                {
                    case 0:
                         master.WriteSingleCoil(slaveID, Address, Value==0?false:true);
                        break;
                    case 1:
                        master.WriteSingleCoil(slaveID, Address, Value == 0 ? false : true);
                        break;
                    case 2:
                        master.WriteSingleRegister(slaveID, Address, Value);
                        break;
                    case 3:
                        master.WriteSingleRegister(slaveID, Address, Value);
                        break;
                    default:
                        MessageBox.Show("功能码错误");
                        datas = null;
                        break;
                }
                txt_show.AppendText("\r\nModbusWrite Success");
              
            }
            catch (Exception eee)
            {
                Error(true, eee);
            }
        }

    }
}
