using EntityFrameWork_1.EntityModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWork_1.Classes
{
    class LoadData
    {
        public void PopulateDataGridView(DataGridView dgv)
        {
            using (PCIEntities db = new PCIEntities())
            {
                db.PCIResponseTickets.Load();
                //dgv.DataSource = db.Priorities.ToList<Priority>();
                dgv.DataSource = db.PCIResponseTickets.ToList<PCIResponseTicket>();

            }
        }
    }
}
