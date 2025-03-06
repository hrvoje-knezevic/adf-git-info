namespace GitAdfInfo.Services
{
    public class NumberService
    {
        public (int Sum, int Smallest, int Largest, int Count) CalculateNumbers(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The numbers array must not be null or empty.");
            }

            int sum = numbers.Sum();
            int smallest = numbers.Min();
            int largest = numbers.Max();
            int count = numbers.Length;

            return (sum, smallest, largest, count);
        }

        public int[] OrderNumbers(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException("The numbers array must not be null.");
            }

            return numbers.OrderBy(n => n).ToArray();
        }
    }

}
