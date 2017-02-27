using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.tjigs.DbAccessFramework;
using System.Data.OleDb;

namespace DatabaseFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // DbUtility DbAccess=new DbUtility ()
           
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DbUtility AccessDB = new DbUtility(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName,DbProviderType .Access );
            List<string>tablenames=AccessDB.GetTableName();
          //  textBox1.Text = openFileDialog1.FileName;
            dgv.Rows.Clear();
            foreach (string name in tablenames)
            {
               DataTable table = AccessDB.GetDbField(name);



                //int i = 0;

                //foreach (DataRow row in table.Rows)
                //{

                //    dgv.Rows.Add(1);
                //    dgv.Rows[i].Cells["dgv_Mc"].Value = row["COLUMN_NAME"].ToString();    //字段名称

                //    int lx = int.Parse(row["DATA_TYPE"].ToString());    //字段类型

                //    switch (lx)
                //    {
                //        case 2: dgv.Rows[i].Cells["dgv_Lx"].Value = "int"; break;
                //        case 3: dgv.Rows[i].Cells["dgv_Lx"].Value = "int"; break;
                //        case 4: dgv.Rows[i].Cells["dgv_Lx"].Value = "Single"; break;
                //        case 5: dgv.Rows[i].Cells["dgv_Lx"].Value = "double"; break;
                //        case 6: dgv.Rows[i].Cells["dgv_Lx"].Value = "decimal"; break;
                //        case 7: dgv.Rows[i].Cells["dgv_Lx"].Value = "DateTime"; break;
                //        case 11: dgv.Rows[i].Cells["dgv_Lx"].Value = "bool"; break;
                //        case 17: dgv.Rows[i].Cells["dgv_Lx"].Value = "byte"; break;
                //        case 72: dgv.Rows[i].Cells["dgv_Lx"].Value = "string"; break;
                //        case 130: dgv.Rows[i].Cells["dgv_Lx"].Value = "string"; break;
                //        case 131: dgv.Rows[i].Cells["dgv_Lx"].Value = "decimal"; break;
                //        case 128: dgv.Rows[i].Cells["dgv_Lx"].Value = "string"; break;
                //        default: dgv.Rows[i].Cells["dgv_Lx"].Value = "string"; break;
                //    }
                //    dgv.Rows[i].Cells["dgv_Lx"].Tag = dgv.Rows[i].Cells["dgv_Lx"].Value.ToString();
                //    dgv.Rows[i].Cells["dgv_Yxk"].Value = bool.Parse(row["IS_NULLABLE"].ToString());    //允许空
                //    dgv.Rows[i].Cells["dgv_Ms"].Value = row["DESCRIPTION"].ToString();    //字段说明、描述
                //    dgv.Rows[i].Cells["dgv_Zj"].Value = false;

                //    i++;
                //}
             //  DataTable dt= AccessDB.GetDbPK(name);
               dgv.DataSource = table;
               //foreach (DataRow dr in dt.Rows )
               //{
               //    for (int j = 0; j < dgv.RowCount-1; j++)
               //    {
               //        if (dgv.Rows[j].Cells["dgv_mc"].Value.ToString() == dr["COLUMN_NAME"].ToString())
               //        {
               //            dgv.Rows[j].Cells["dgv_Zj"].Value = true;    //主键
               //        }
               //    }
               //}
                   
            }
          

                    //table = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, null);    //主键

                    //foreach (DataRow row in table.Rows)
                    //{
                    //    if (sjbmc == row["TABLE_NAME"].ToString())
                    //    {
                    //        for (int j = 0; j < dgv.RowCount; j++)
                    //        {
                    //            if (dgv.Rows[j].Cells["dgv_mc"].Value.ToString() == row["COLUMN_NAME"].ToString())
                    //            {
                    //                dgv.Rows[j].Cells["dgv_Zj"].Value = true;    //主键
                    //            }
                    //        }
                    //    }
                    //}

                  //  connection.Close();
           // DbUtility DbAccess = new DbUtility(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + openFileDialog1.FileName + ";Persist Security Info=True", DbProviderType.Access);
           // DbAccess.
        }
        
    }
}
