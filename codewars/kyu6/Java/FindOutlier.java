package codewars.kyu6;

// Source: https://www.codewars.com/kata/5526fc09a1bbd946250002dc

import java.io.File;
import java.io.FileNotFoundException;
import java.math.BigInteger;
import java.util.Scanner;

public class FindOutlier {
    public static void main(String[] args) throws FileNotFoundException {
        System.out.println(find(new int[]{2, 6, 8, 10, 3}));
    }
    static int find(int[] integers) {
        // Identify the array. Even or Odd.
        // Find the Outlier.

        int id = 0; // 0 = even, 1 = odd
        int even = 0;

        for (int i=0; i<3; i++) {
            if (integers[i]%2==0) even++;
        }

        id = even > 1 ? 0 : 1;

        for (int n :  integers) {
            if (!(n%2==id)) {
                return n;
            }
        }

        return 0;
    }
}
