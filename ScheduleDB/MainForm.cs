using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleDB
{
    public partial class MainForm : Form
    {
        private PairRepository pairRepository;
        public MainForm()
        {
            InitializeComponent();
            pairRepository = new PairRepository();
        }

        private void NumberEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SimpleEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MultiplyEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                string result = ((TextBox)sender).Text;

                if (!(result[result.Length - 1] == ',') &&
                    (result.Substring(result.LastIndexOf(",") + 2).Contains(' ')))
                {
                    e.Handled = true;
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DayEntry.Text) &&
                !string.IsNullOrWhiteSpace(TypeEntry.Text) &&
                !string.IsNullOrWhiteSpace(NumberEntry.Text) &&
                !string.IsNullOrWhiteSpace(SubjectEntry.Text) &&
                !string.IsNullOrWhiteSpace(TutorEntry.Text) &&
                !string.IsNullOrWhiteSpace(AuditoriumEntry.Text) &&
                !string.IsNullOrWhiteSpace(GroupsEntry.Text))
            {
                pairRepository.CreateNewPair(new ScheduleModels.Pair()
                {
                    Type = TypeEntry.Text,
                    Day = DayEntry.Text,
                    NumberOfPair = Convert.ToInt32(NumberEntry.Text),
                    Subject = SubjectEntry.Text,
                    Tutors = TutorEntry.Text.
                                        Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries).
                                        ToList(),

                    Auditoriums = new List<int>(
                                        Array.ConvertAll(
                                            AuditoriumEntry.Text.
                                                            Split(new String[] { ", " },
                                                            StringSplitOptions.RemoveEmptyEntries), 
                                            Convert.ToInt32)),

                    Groups = GroupsEntry.Text.
                                        Split(new String[] { ", " }, StringSplitOptions.RemoveEmptyEntries).
                                        ToList()
                });
            }
        }
    }
}
