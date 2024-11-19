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

namespace Labo_11___Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }
        //Deel 1
        private void SearchNumber_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = new int[6];
            numbers = [100, 50, 20, 60, 90, 80];
            int[] result;

            result = ReturnSmallestAndBiggest(numbers);

            outputTextBox.Text = $"int[] result = {{ {result[0]}, {result[1]}}}";

            //int smallestNumber = numbers[0];
            //int biggestNumber = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < smallestNumber)
            //    {
            //        smallestNumber = numbers[i];
            //    }
            //    if (numbers[i] > biggestNumber)
            //    {
            //        biggestNumber = numbers[i];
            //    }
            //}
            //outputTextBox.Text = $"In totaal zijn er {numbers.Length} getallen:\nKleinste getal = {smallestNumber}\nGrootste getal = 100";
        }

        private int[] ReturnSmallestAndBiggest(int[] numbers)
        {
            int smallest;
            int biggest;
            smallest = numbers.Min();
            biggest = numbers.Max();

            int[] smallestAndBiggest = { smallest, biggest};

            return smallestAndBiggest;
        }

    }
}