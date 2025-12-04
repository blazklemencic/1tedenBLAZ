using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _9teden_doodle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer timer;
        private double velocity = 0;
        private readonly double gravity = -1.0;
        private readonly double jumpPower = 9;
        private bool isJumping = false;

        private bool moveLeft = false;
        private bool moveRight = false;
        private const double speed = 5;
        TimeSpan elapsed = TimeSpan.Zero;

        List<Rectangle> elementiZaOdstranitev = new List<Rectangle>();

        public MainWindow()
        {
            InitializeComponent();
            this.Focus();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Loop;
            timer.Start();
        }

        private void Loop(object sender, EventArgs e)
        {
            elapsed.Add(timer.Interval);
            double player_bottom = Canvas.GetBottom(Player);
            double player_left = Canvas.GetLeft(Player);
            double player_right = player_left + Player.ActualWidth;
            double player_top = player_bottom + Player.ActualHeight;
            double width = GameCanvas.ActualWidth;
            double height = GameCanvas.ActualHeight;

            if (moveLeft && player_left >= 0) player_left -= speed;
            if (moveRight && player_left <= (width - Player.ActualWidth)) player_left += speed;
            Canvas.SetLeft(Player, player_left);

            player_bottom += velocity;
            velocity += gravity;

            if (player_bottom <= 0)
            {
                Canvas.SetBottom(Player, 0);
                velocity = 0;
                isJumping = false;
            }
            if ((player_bottom + Player.ActualHeight) >= height)
            {
                TheEND(true);
            }

            Canvas.SetBottom(Player, player_bottom);

            foreach (Rectangle rect in elementiZaOdstranitev)
            {
                double left = Canvas.GetLeft(rect);
                double bottom = Canvas.GetBottom(rect);
                double right = left + rect.ActualWidth;
                double top = bottom + rect.ActualHeight;

                if (player_right >= left && player_left <= right && player_bottom <= top && player_top >= bottom)
                {
                    Debug.WriteLine($"Removing Rectangle: Left={left}, Right={right}, Top={top}, Bottom={bottom}");
                    Debug.WriteLine($"Player position: Left={player_left}, Right={player_right}, Top={player_top}, Bottom={player_bottom}");
                    GameCanvas.Children.Remove(rect);
                }
            }

            if (elapsed.Seconds % 2 == 0)
            {
                Random r = new Random();
                double w = 0;
                double h = 0;
                w = r.NextDouble() * width;
                h = r.NextDouble() * height;

                Rectangle bub = new Rectangle
                {
                    Width = 20,
                    Height = 20,
                    Fill = new SolidColorBrush(Colors.Red),
                };
                Canvas.SetLeft(bub, w);
                Canvas.SetTop(bub, h);
                GameCanvas.Children.Add(bub);
                elementiZaOdstranitev.Add(bub);
            }
        }

        private void Start()
        {

        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) moveLeft = true;
            if (e.Key == Key.Right) moveRight = true;

            if (e.Key == Key.Up)
            {
                velocity = jumpPower;
                isJumping = true;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) moveLeft = false;
            if (e.Key == Key.Right) moveRight = false;
        }

        private void TheEND(bool lost)
        {
            if (lost)
            {
                Player.Visibility = Visibility.Hidden;

                MessageBox.Show("Ummmmm you lost. WE SET THE ROOF, ON, FIRE!");
                System.Environment.Exit(0);
                return;
            }
        }
    }
}