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

namespace solid_design_principles
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

        private void btnSingleResponsibilityViolation_Click(object sender, RoutedEventArgs e)
        {
            SingleResponsibilityViolation.Invoice _IncorrectInvoice = new SingleResponsibilityViolation.Invoice();
            _IncorrectInvoice.AddInvoice();         
        }

        private void btnProperSingleResponsbility_Click(object sender, RoutedEventArgs e)
        {
            BreaksOpenClosed.Invoice _OpenClosedViolation=new BreaksOpenClosed.Invoice();
            _OpenClosedViolation.GetInvoiceDiscount(11, BreaksOpenClosed.InvoiceType.RecurringInvoice);
        }

        private void btnProperOpenClosedPricinple_Click(object sender, RoutedEventArgs e)
        {
            ProperOpenClosed.RecurringInvoice _RecurringInvoice=new ProperOpenClosed.RecurringInvoice();
            _RecurringInvoice.GetInvoiceDiscount(211);
        }

        private void btnLiskovPrincipleViolation_Click(object sender, RoutedEventArgs e)
        {
            LiskovViolation.Apple _apple = new LiskovViolation.Apple();
            MessageBox.Show($"apple color: {_apple.GetColor()}");

            LiskovViolation.Orange _orange = new LiskovViolation.Orange();
            MessageBox.Show($"orange color: {_orange.GetColor()}");

            LiskovViolation.Apple _apple_orange = new LiskovViolation.Orange();
            MessageBox.Show($"orange type apple color: {_apple_orange.GetColor()}");
        }

        private void btnProperLiskovPricinple_Click(object sender, RoutedEventArgs e)
        {
            ProperLiskovPrinciple.Apple _apple = new ProperLiskovPrinciple.Apple();
            MessageBox.Show($"apple color: {_apple.GetColor()}");

            ProperLiskovPrinciple.Orange _orange = new ProperLiskovPrinciple.Orange();
            MessageBox.Show($"orange color: {_orange.GetColor()}");

            ProperLiskovPrinciple.Fruit _fruit_orange = new ProperLiskovPrinciple.Orange();
            MessageBox.Show($"fruit orange color: {_fruit_orange.GetColor()}");

            ProperLiskovPrinciple.Fruit _fruit_apple = new ProperLiskovPrinciple.Apple();
            MessageBox.Show($"fruit apple color: {_fruit_apple.GetColor()}");
        }

        private void btnInterfaceSegreationViolation_Click(object sender, RoutedEventArgs e)
        {
            InterfaceViolation.HPLaserJetPrinter _hpLaser = new InterfaceViolation.HPLaserJetPrinter();
            _hpLaser.Fax("test");
        }

        private void btnProperInterfaceSegregation_Click(object sender, RoutedEventArgs e)
        {
            ProperInterfaceSegration.HPLaserJetPrinter _hpLaser = new ProperInterfaceSegration.HPLaserJetPrinter();
            _hpLaser.PrintDuplex("test");
        }

        private void btnDependencyInversionViolation_Click(object sender, RoutedEventArgs e)
        {
            DependencyInversionViolation.EmployeeBusinessLogic _MainLogic = new DependencyInversionViolation.EmployeeBusinessLogic();
            _MainLogic.GetEmployeeDetails(32);
        }

        private void btnProperDependencyInversion(object sender, RoutedEventArgs e)
        {
            ProperDependencyInversion.EmployeeBusinessLogic _MainLogic = new ProperDependencyInversion.EmployeeBusinessLogic();
            _MainLogic.GetEmployeeDetails(32);
        }
    }
}
