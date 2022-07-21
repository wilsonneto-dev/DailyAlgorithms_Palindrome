public class Solution {
    public bool ValidPalindrome(string s) {
        var chars = s.ToCharArray();
        var indexPointer1 = 0;
        var indexPointer2 = s.Length - 1;
        while(indexPointer1 < indexPointer2)
            if(chars[indexPointer1++] != chars[indexPointer2--])
                return false;
        return true;
    }
}
