package com.luis.tdd.fibonacci;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class FibonacciTest {

    private int num;
    private int[] serieFibonacci;
    Fibonacci fibonacci;

    @BeforeEach
    void setUp() {
        fibonacci = new Fibonacci();
        num = 10;
        serieFibonacci = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
    }

    @Test
    void test_check_the_fibonacci_length_is_correct(){
        int[] fib = fibonacci.Serie(this.num);
        assertEquals(this.num, fib.length);
    }

    @Test
    void test_check_the_fibonacci_length_is_incorrect(){
        int[] fib = fibonacci.Serie(this.num);
        assertEquals(this.num, fib.length);
    }

    @Test
    void test_check_serie_fibonacci_is_correct(){
        int[] fib = fibonacci.Serie(this.num);
        for (int i = 0; i < fib.length; i++) {
            assertEquals(this.serieFibonacci[i], fib[i]);
        }
    }

    @Test
    void test_check_serie_fibonacci_is_incorrect(){
        int[] fib = fibonacci.Serie(this.num);
        for (int i = 0; i < fib.length; i++) {
            assertNotEquals(this.serieFibonacci[i], 10);
        }
    }

    @Test
    void test_check_fibonacci_series_when_type_number_2(){
        int[] fib = fibonacci.Serie(2);
        assertEquals(fib, null);
    }

    @Test
    void test_check_fibonacci_series_when_type_number_1(){
        int[] fib = fibonacci.Serie(1);
        assertEquals(fib, null);
    }

    @Test
    void test_check_fibonacci_series_when_type_number_less_than_0(){
        int[] fib = fibonacci.Serie(-1);
        assertEquals(fib, null);
    }

}