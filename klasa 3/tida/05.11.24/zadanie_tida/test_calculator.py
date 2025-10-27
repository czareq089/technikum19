import unittest
import calculator




class MyTestCase(unittest.TestCase):
    def test_suma(self):
        result = calculator.suma(10,20)
        self.assertEqual(result, 30)  # add assertion here
    def test_suma_neg(self):
        result = calculator.suma(-10,-20)
        self.assertEqual(result, -30)
    def test_nwd(self):
        result = calculator.nwd(90, 60)
        self.assertEqual(result, 30)

class MyTestCase2(unittest.TestCase):
    def test_suma(self):
        result = calculator.suma(10,20)
        self.assertEqual(result, 30)  # add assertion here
    def test_suma_neg(self):
        result = calculator.suma(-10,-2)
        self.assertEqual(result, -12)
    def test_nwd2(self):
        result = calculator.nwd(7, 9)
        self.assertEqual(result, 1)

class MyTestCase3(unittest.TestCase):
    def test_srednia3(self):
        result = calculator.srednia3(15,10, 20)
        self.assertEqual(result, 15)  # add assertion here
    def test_srednia_neg(self):
        result = calculator.srednia3(-15,-10,-20)
        self.assertEqual(result, -15)
    def test_nwd3(self):
        result = calculator.nwd(-5, 10)
        self.assertEqual(result, 5)

if __name__ == '__main__':
    unittest.main()