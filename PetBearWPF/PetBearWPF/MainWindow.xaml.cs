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
using System.Windows.Threading;
using static PetBearWPF.Utility;

namespace PetBearWPF;


/*
 * Pet Bear Game
 * Grace Siegwald
 * 4/28/2025
 * 
 * 
 * 
 * All images are from /www.flaticon.com/ which I have a premium subscription for
 * 
 * The "timer" part of the code was written with the help of ChatGPT. I gave it the code that I currently had at the time, and it gave me this information:
                
                Make Pats Auto-Generate
                You have a nice ApplyPassivePats() method in PatManager. Great!
                Now you need it to run every second.

                How? Use a Timer.

                Example to set this up inside your MainWindow:

                private DispatcherTimer passivePatTimer;

                public MainWindow()
                {
                    InitializeComponent();
    
                    passivePatTimer = new DispatcherTimer();
                    passivePatTimer.Interval = TimeSpan.FromSeconds(1);
                    passivePatTimer.Tick += PassivePatTimer_Tick;
                    passivePatTimer.Start();
                }

                private void PassivePatTimer_Tick(object sender, EventArgs e)
                {
                    manager.ApplyPassivePats();
                    UpdatePatCounter();
                }
                Explanation:

                DispatcherTimer runs code every second.

                Every second, it calls your ApplyPassivePats() method, and updates the display.

                Now upgrades will work automatically after buying them!
 */



/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private PatManager manager = new PatManager();
    private int smallUpgradeCount = 0;
    private int mediumUpgradeCount = 0;
    private int largeUpgradeCount = 0;

    private DispatcherTimer passivePatTimer;

    AutoUpgrade smallUpgrade = new AutoUpgrade
    {
        Name = "Small Pat",
        Cost = 10,
        PetsPerSecond = 1
    };
    AutoUpgrade mediumUpgrade = new AutoUpgrade
    {
        Name = "Medium Pat",
        Cost = 50,
        PetsPerSecond = 5
    };
    AutoUpgrade largeUpgrade = new AutoUpgrade
    {
        Name = "Large Pat",
        Cost = 200,
        PetsPerSecond = 20
    };


    // I used ChatGPT to help write this "timer" code, as I wasn't exactly sure where to even start with it...
    public MainWindow()
    {
        InitializeComponent();
        TeddyBearImage.Source = new BitmapImage(new Uri("pack://application:,,,/Media/teddy-bear.png"));

        manager.AddUpgrade(smallUpgrade);
        manager.AddUpgrade(mediumUpgrade);
        manager.AddUpgrade(largeUpgrade);

        passivePatTimer = new DispatcherTimer();
        passivePatTimer.Interval = TimeSpan.FromSeconds(1);
        passivePatTimer.Tick += PassivePatTimer_Tick;
        passivePatTimer.Start();
    }

    private void PassivePatTimer_Tick(object sender, EventArgs e)
    {
        manager.ApplyPassivePats();
        UpdatePatCounter();
    }



    private void UpdatePatCounter()
    {
        PatCounter.Text = $"{manager.TotalPats} Pats";
    }
    
    private void TeddyBearImage_MouseDown(object sender, MouseButtonEventArgs e)
    {
        // And increment the TotalPat counter by 1
        manager.Pat();
        UpdatePatCounter();
        Console.Text = "";
    }

    private void SmallUpgradeButton_Click(object sender, RoutedEventArgs e)
    {
        if (manager.SpendPats(smallUpgrade.Cost))
        {
            smallUpgrade.Buy();
            smallUpgradeCount++;
            SmallUpgradeCount.Text = $"Count: {smallUpgradeCount}";
            Console.Text = "You bought an Upgrade!";
        }
        else
        {
            Console.Text = "You don't have enough Pats!";
        }
        
        UpdatePatCounter();
    }

    private void MediumUpgradeButton_Click(object sender, RoutedEventArgs e)
    {


        if (manager.SpendPats(mediumUpgrade.Cost))
        {
            mediumUpgrade.Buy();
            mediumUpgradeCount++;
            MediumUpgradeCount.Text = $"Count: {mediumUpgradeCount}";
            Console.Text = "You bought an Upgrade!";
        }
        else
        {
            Console.Text = "You don't have enough Pats!";
        }

        UpdatePatCounter();
    }

    private void LargeUpgradeButton_Click(object sender, RoutedEventArgs e)
    {
        

        if (manager.SpendPats(largeUpgrade.Cost))
        {
            largeUpgrade.Buy();   
            largeUpgradeCount++;
            LargeUpgradeCount.Text = $"Count: {largeUpgradeCount}";
            Console.Text = "You bought an Upgrade!";
        }
        else
        {
            Console.Text = "You don't have enough Pats!";
        }

        UpdatePatCounter();
    }

    private void TeddyBearImage_MouseEnter(object sender, MouseEventArgs e)
    {
        TeddyBearImage.Source = new BitmapImage(new Uri("pack://application:,,,/Media/teddy-bear2.png"));
    }

    private void TeddyBearImage_MouseLeave(object sender, MouseEventArgs e)
    {
        TeddyBearImage.Source = new BitmapImage(new Uri("pack://application:,,,/Media/teddy-bear.png"));
    }
}