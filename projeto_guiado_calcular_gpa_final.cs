// Projeto guiado – Calcular GPA final

// declara o nome de cada aluno
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

// declara os creditos de cada disciplina
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

// declarar variável para cada valor numérico de nota
int gradeA = 4;
int gradeB = 3;

// armazenam as notas de cada curso
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

// armazena o total de horas de créditos
int totalCreditHours = 0;

//incrementa a soma de créditos
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// armazena o número total de pontos de nota ganho para cada curso
int totalGradePoints = 0;

// incrementa a soma pelos pontos de nota ganhos no primeiro curso
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

// armazena o GPA Final
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

// armazena o dígito inicial do GPA
int leadingDigit = (int) gradePointAverage;

// armazena os dois primeiros dígitos após o separador decimal
int firstDigit = (int) (gradePointAverage * 10) % 10;

// armazena o segundo dígito 
int secondDigit = (int) (gradePointAverage * 100) % 10;

// adiciona o nome do aluno
Console.WriteLine($"Student: {studentName}\n");

// adiciona um cabeçalho com informações do curso
Console.WriteLine("Course\t\t\t\tGrade\tCredi Hours");

// exibe os nomes do curso junto com a nota numérica e as horas de crédito
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

// exibe o GPA Final
Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}. {firstDigit}{secondDigit}");