public class Student
{
    public string Name { get; set; }
    public int Score { get; private set; }
    
    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }
}

// 다음 코드가 실행되면 어떻게 될까요?
// Student s = new Student("김철수", 85);
// s.Score = 100;  // 이 줄은 어떻게 될까?