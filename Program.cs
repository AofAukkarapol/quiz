using System;

class Program {
    static void Main(string[] args) {
        double count = 0;
        double sum = 0;
        double max = int.MinValue;
        double min = int.MaxValue;
        bool is_end = false;
        while (!is_end) {
            Console.Write("Enter a number or type 'End' to stop: ");
            string user_input = Console.ReadLine();
            if (user_input.ToLower() == "end") {
                is_end = true;
            }
            else if (double.TryParse(user_input, out double number)) {
                count++;
                sum += number;
                max = Math.Max(max, number);
                min = Math.Min(min, number);
            }
            else {
                Console.WriteLine("Invalid mode");
            }
        }

            Console.Write("Enter a mode (FindMax, FindMin, FindMean) or type 'End' to exit: ");
            string mode = Console.ReadLine().ToLower();
            
            switch (mode) {
                case "findmax":
                    Console.WriteLine($"Max value: {max}");
                    break;
                case "findmin":
                    Console.WriteLine($"Min value: {min}");
                    break;
                case "findmean":
                    if (count > 0) {
                        Console.WriteLine($"Mean value: {(double)sum / count}");
                    }
                    else {
                        Console.WriteLine("No numbers were entered.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid mode. Please enter a valid mode.");
                    break;
            }
        }
    }