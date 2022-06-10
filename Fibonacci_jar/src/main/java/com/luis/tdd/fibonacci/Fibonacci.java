package com.luis.tdd.fibonacci;

public class Fibonacci {
    public int[] Serie(int num){
        if(num <= 2)
            return null;

        int[] fib = new int[num];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i < num; i++) {
            fib[i] = fib[i-1] + fib[i-2];
        }
        return fib;
    }
}

