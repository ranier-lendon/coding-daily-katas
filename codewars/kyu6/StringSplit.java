package codewars.kyu6;

public class StringSplit {
    public static String[] solution(String s) {
        int l = s.length(); // Length of string
        String [] arr = new String[Math.round(l/2f)]; // Instantiate an array

        for (int i=0; i<l; i+=2) {
            // Checks for the last element in odd string and add "_" on the last.
            if (l%2==1 && i+1==l) {
                arr[l/2] = s.charAt(i) + "_";
                break;
            }

            // Appends 2 string in the array
            arr[i/2] = s.substring(i, i+2);
        }

        return arr;
    }
}
