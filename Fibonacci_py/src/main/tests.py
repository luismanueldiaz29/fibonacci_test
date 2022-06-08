import unittest
from fibonacci import Serie

class tests(unittest.TestCase):
    num = int()
    serieTest = list()
    serieTestError = list()

    def setUp(self):
        self.serieTest = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];
        self.serieTestError = [2, 4, 5, 6, 7, 1, 2, 3, 4, 6];
        self.num = 10;

    def test_check_the_fibonacci_length_is_correct(self):
        print(self.num)
        fib = Serie.calculate_fibonacci_series(self.num)
        self.assertEqual(len(fib), self.num)

    def test_check_the_fibonacci_length_is_incorrect(self):
        print(self.num)
        fib = Serie.calculate_fibonacci_series(self.num)
        self.assertNotEqual(len(fib), self.num - 1)
    
    def test_check_the_fibonacci_sequence_is_correct(self):
        fib = Serie.calculate_fibonacci_series(self.num)
        for i in range(0, len(fib)):
            self.assertEqual(fib[i], self.serieTest[i])
    
    def Test_check_the_fibonacci_sequence_incorrect(self):
        fib = Serie.calculate_fibonacci_series(self.num)
        self.assertEqual(fib.count, self.serieTestError.count)
    
    def Test_check_the_fibonacci(self):
        fib = Serie.calculate_fibonacci_series(self.num-1)
        self.assertNotEqual(len(fib), len(self.serieTestError))

if __name__ == "__main__":
    unittest.main()
