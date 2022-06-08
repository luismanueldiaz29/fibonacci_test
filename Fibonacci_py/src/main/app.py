from fibonacci import Serie

def main(): 
    count = input("Numeros a consultar: ")
    fib = Serie.calculate_fibonacci_series(count);
    print(fib)
    
if __name__ == '__main__':
    import sys
    sys.exit(int(main() or 0))

