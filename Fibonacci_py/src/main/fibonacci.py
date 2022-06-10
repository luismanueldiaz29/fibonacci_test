class Serie:
    fib = list()
    def calculate_fibonacci_series(num):
        fib = [0, 1]
        for i in range(2, int(num)):
            fib.append(fib[i - 1] + fib[i - 2])
        return fib;