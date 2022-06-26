using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Project.Database;

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for UserControlComment.xaml
    /// </summary>
    public partial class UserControlComment : UserControl
    {
        Citizen MainCitizen;

        string TheComment;

        public UserControlComment()
        {
            InitializeComponent();
        }

        public UserControlComment(Citizen citizen)
        {
            MainCitizen = citizen;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TheComment = CommentBox.Text;

            Comment comment = new Comment(TheComment);

            using(EDatabase eDatabase = new EDatabase())
            {
                Citizen citizen = eDatabase.citizens.Find(MainCitizen.CitizenID);
                
                
                comment.Citizen = citizen;
                citizen.comments.Add(comment);
                eDatabase.comments.Add(comment);

                eDatabase.Entry(citizen).State = System.Data.Entity.EntityState.Modified;
                eDatabase.SaveChanges();

            }


        }
    }
}
