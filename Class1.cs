using System;
public class Class1
{
    ////////////   Question NO ONE   /////////
    public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            bool check = true;
            for (var i = 0; i < nums.Length; i++)
            {
                var j = (i + 1) % nums.Length;
                if (i != j)
                    if (nums[i] == nums[j])
                        return check; 
                
            }
            return false;
        }

    ////////////   Question NO TWO -need reviwe-  /////////
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] arr = new int[2];
        int diff = 0, index = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];

            if (diff == nums[i])
                index = Array.LastIndexOf(nums, diff);
            else index = Array.IndexOf(nums, diff);

            if (i < index)
            {
                arr[0] = i;
                arr[1] = index;
                return arr;
            }
            else if (i > index && index > 0)
            {
                arr[0] = index;
                arr[1] = i;
                return arr;
            }
        }

        return arr;

    }

    ////////////   Question NO THREE   /////////
    public static int MaxProfit(int[] arr)
    {
        int flag1 = 0, flag2 = 0, maxProfit = 0, profit = 0;
        while (flag2 < arr.Length)
        {
            if (arr[flag2] > arr[flag1])
            {
                profit = arr[flag2] - arr[flag1];
                maxProfit = Math.Max(profit, maxProfit);

            }
            else flag1 = flag2;
            flag2++;
        }

        return maxProfit;
    }

    ///////////    Question NO FOUR   /////////
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int flag1 = 0, flag2 = 0, i = 0;
        int[] temp = new int[n + m];
        if (n > 0 && m > 0)
        {
            if (n == 1 && m == 1)
            {
                if (nums1[0] >= nums2[0])
                {
                    temp[0] = nums2[0];
                    temp[1] = nums1[0];
                }
                else if (nums1[0] < nums2[0])
                {
                    temp[0] = nums1[0];
                    temp[1] = nums2[0];
                }
            }
            else
            {
                while (flag1 < m)
                {
                    if (nums1[flag1] < nums2[flag2])
                    {
                        temp[i] = nums1[flag1];
                        flag1++;
                        i++;
                    }
                    else if (nums1[flag1] == nums2[flag2])
                    {
                        temp[i] = nums1[flag1];
                        flag1++;
                        i++;
                        temp[i] = nums2[flag2];
                        flag2++;
                        i++;

                    }
                }
                while (flag2 < n)
                {

                    temp[i] = nums2[flag2];
                    flag2++;
                    i++;
                }
            }
        }
        else
        {
            if (m == 0)
                temp = nums2;
            else if (n == 0)
                temp = nums1;
        }
        nums1 = temp;
        for (i = 0; i < (n + m); i++)
        {
            Console.Write(nums1[i] + " ");
        }

    }

    ///////////    Question NO FIVE   /////////

    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        (int, int)[] temp = { };
        int[] temp2 = { }, result;
        int n = 0, j = 0, lengthResult = 0;

        if (nums1.Length > nums2.Length)
        {
            temp = new (int, int)[nums1.Length];
            temp2 = nums2;
            for (int i = 0; i < nums1.Length; i++)
            {

                temp[i].Item1 = nums1[i];
            }

        }
        else if (nums1.Length <= nums2.Length)
        {
            temp = new (int, int)[nums2.Length];
            temp2 = nums1;

            for (int i = 0; i < nums2.Length; i++)
            {

                temp[i].Item1 = nums2[i];
            }

        }

        while (j < temp2.Length)
        {
            n = Array.IndexOf(temp, (temp2[j], 0));
            if (n >= 0)
            {
                temp[n].Item2++;
                lengthResult++;
            }
            j++;

        }
        result = new int[lengthResult];

        for (int x = 0, l = 0; x < temp.Length; x++)
        {
            if (l < lengthResult)
                while (temp[x].Item2 > 0)
                {
                    result[l] = temp[x].Item1;
                    temp[x].Item2--;
                    l++;
                }
        }
        return result;

    }




}
