package codewars.kyu6;

// Source: https://www.codewars.com/kata/517abf86da9663f1d2000003

public class toCamelCase {
    static String toCamelCase(String s){
        // Splits the input string by hyphens and underscores.
        String[] arr = s.split("[-_]");
        String res;

        // Convert each word (starting from the second) to capitalize the first letter
        for(int i = 1; i < arr.length; i++){
            arr[i] = arr[i].substring(0, 1).toUpperCase().concat(arr[i].substring(1));
        }

        // Join all parts together into a single string and return it
        res = String.join("", arr);
        return res;
    }
}
