package codewars.kyu6;

import java.util.Arrays;

// Source: https://www.codewars.com/kata/550498447451fbbd7600041c

public class AreSame {

    public static boolean comp(int[] a, int[] b) {
        if (a==null || b==null) return false;
        if (a.length != b.length) return false;

        int[] A = new int[a.length];

        // Store squared values in A
        for (int x=0; x<a.length; x++) {
            A[x] = a[x] * a[x];
        }

        Arrays.sort(A);
        Arrays.sort(b);

        // Checks every values of A and B if they are not the same
        for (int i = 0; i < a.length; i++) {
            if (A[i] != b[i]) {
                return false;
            }
        }

        // if all the values are the same return true
        return true;
    }
}