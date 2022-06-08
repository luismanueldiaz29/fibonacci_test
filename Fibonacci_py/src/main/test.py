import this
import unittest
from fibonacci import Serie

class test(unittest.TestCase):
    num = int()
    serieTest = list()
    def setUp(self):
        self.serieTest = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];
        self.num = 10;
        print("Entra setUp")

    def test1(self):
        fib = Serie.calculate_fibonacci_series(self.num)
        self.assertEqual(len(fib), self.num)

if __name__ == "__main__":
 unittest.main()
