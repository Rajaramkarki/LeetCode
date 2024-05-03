public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        int length = flowerbed.Length;

        for(int i = 0; i < flowerbed.Length; i++)
        {        
            if(flowerbed[i] == 0 && 
            (i == 0 || flowerbed[i - 1] == 0) && 
            (i == length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
            }
        }

        if(n <= count)
            return true;

        else 
            return false;
    }
}