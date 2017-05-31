using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> num = new List<int>();
        List<Question> ls_question = new List<Question>();
        Random random = new Random();
        int count, number;
        public MainWindow()
        {
            InitializeComponent();

            if (ls_question == null)
            {
                ls_question = new List<Question>();
            }
            ls_question = MyStorage.readXml<List<Question>>("Question.xml");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           // pickQuestion();
            //    Question question = new Question();
            //question.question = "why are you not using intelligence?";
            //question.answers.Add(new Answer { answer = "not used to", status = true });
            //question.answers.Add(new Answer { answer = "I likw writing", status = false });
            //question.answers.Add(new Answer { answer = "lazy", status = false });

            //ls_question.Add(question);
            
           //MyStorage.storeXml<List<Question>>(ls_question,"Question.xml");
            //ls_question = MyStorage.readXml<List<Question>>("Question.xml");
             sp_question.DataContext = ls_question[pickQuestion()];
        }

        private int pickQuestion()
        {
            
            if (ls_question.Count != num.Count)
                {
                  while (true)
                {
                    count = 0;
                    number = random.Next(ls_question.Count);
                    if (num.Count == 0)
                    {
                        num.Add(number);
                        break;
                    }
                    else
                    {
                        foreach (int i in num)
                        {
                            if (i == number)
                            {
                                count = 1;
                                break;
                            }
                        }
                    }
                    if (count == 0)
                    {
                        num.Add(number);
                        break;
                    }
                }
            }
            return number;
              
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            var item = lb_answer.SelectedItem;
            if(item==null)
            {
                MessageBox.Show("Please select answer","Waring");
                return;
            }
            if ((item as Answer).status)
            {
                MessageBox.Show("Correct Answer!");
                if (num.Count != ls_question.Count)
                {
                    sp_question.DataContext = ls_question[pickQuestion()];
                }
                else
                {
                    if(MessageBox.Show("Quiz over! u want to restart", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning)==MessageBoxResult.Yes)
                    {
                        Reset();
                        InitializeComponent();
                    }
                    else
                    {
                        this.Close();
                    }
                                        
                }
            }
            else
            {
                MessageBox.Show("Wrong Answer!!!");
            }
        }

        private void Reset()
        {
            num = new List<int>();
        }
    }
}
