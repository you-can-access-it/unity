using UnityEngine;

public class prac1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheckOdd(3);
        CheckOdd(4);
        CalculateGrade(7);
        int sum = SumFirstN(5);
        Debug.Log("Sum of first 5 natural numbers: " + sum);
        int evenSum = SumEvenInRange(1, 10);
        Debug.Log("Sum of even numbers from 1 to 10: " + evenSum);
    }
// Function to check if a number is odd
void CheckOdd(int num)
    {
        if (num % 2 != 0)
        {
            Debug.Log(num + " is odd");
        }
        else
        {
            Debug.Log(num + " is not odd");
        }
    }
    // Function to calculate the grade based on the score
void CalculateGrade(int a)
    {
        string grade; 
        switch (a)
        {
            case 10:
            case 9:
                grade = "A";
                break;
            case 8:
                grade = "B";
                break;
            case 7:
                grade = "C";
                break;
            case 6:
                grade = "D";
                break;
            default:
                grade = "F";
                break;
     }
        Debug.Log("Score: " + score + " => Grade: " + grade);
    }
    // Function to calculate the sum of first n natural numbers
int SumFirstN(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
    // Function to calculate the sum of even numbers in a given range
int SumEvenInRange(int a, int b)
    {
        int sum = 0;
        int i = a;
        while (i <= b)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
            i++;
        }
        return sum;
    }



}
