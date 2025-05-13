package codewars.kyu5;

import java.util.regex.Pattern;

// Source: https://www.codewars.com/kata/520b9d2ad5c005041100000f

public class PigLatin {
    public static String pigIt(String str) {
        Pattern checker = Pattern.compile("\\p{P}");

        String[] arr = str.split(" ");

        for (int i = 0; i < arr.length; i++) {
            // checks for current index if it is a punctuation mark
            if (!checker.matcher(arr[i]).matches()){
                // this code just put the first letter to the last and add "ay" at the end
                arr[i] = arr[i].substring(1).concat(arr[i].substring(0, 1)).concat("ay");
            }
        }

        // joins all the array to the string and separate them by space.
        return "".join(" ", arr);
    }
}
