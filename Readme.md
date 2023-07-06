<h2>Test Suite 1: StudentConverterTests</h2>
<p>
The <code>StudentConverterTests</code> suite employs Xunit testing framework for validating the functionality of the <code>StudentConverter</code> class within the <code>UC7Tests</code> namespace. The test suite consists of six unit tests that assess different aspects of the <code>StudentConverter.ConvertStudents</code> method.
</p>

<p>
The test cases are devised to check the proper conversion of student information, for instance: when a student with a grade above 90 is converted, the 'HonorRoll' and 'Exceptional' flags become true; when a student with a grade above 70 is converted, the 'Passed' flag becomes true; and when a student with a grade below 70 is converted, the 'Passed' flag remains false. Also, the test suite covers edge cases, such as when an empty list of students or a null value is passed to the <code>ConvertStudents</code> method. These checks ensure the method's robustness by confirming that it behaves as expected in various situations.
</p>

<h2>Test Suite 2: PlayerAnalyzerTests</h2>
<p>
The <code>PlayerAnalyzerTests</code> suite, also written with the Xunit testing framework, verifies the operation of the <code>PlayerAnalyzer</code> class in the <code>UC7Tests</code> namespace. This test suite contains six tests, all centred on the <code>PlayerAnalyzer.CalculateScore</code> method.
</p>

<p>
The tests assess the method's ability to correctly calculate the scores of players based on their age, experience, and skills: a 'Normal' player with certain skills and experience returns a correct score; a 'Junior' player with less experience but good skills also returns a correct score; and a 'Senior' player with a high level of experience and skills yields the correct score. Additional test cases verify the method's response to different edge cases such as when a player has null skills, or when the method is given an empty array. These tests ensure that the method functions reliably under a wide range of conditions.
</p>

<h2>Running the Tests Locally</h2>
<p>
To run the test suites locally, follow these steps:
</p>
<ol>
    <li>Ensure you have the .NET Core SDK installed on your machine. If you don't have it, download it from the official Microsoft website.</li>
    <li>Open your terminal/command prompt and navigate to the directory containing the test project (the directory containing the .csproj file).</li>
    <li>Execute the command <code>dotnet test</code> in the terminal/command prompt. This will build the project and run all the tests.</li>
    <li>Review the output of the test command in the terminal/command prompt to see which tests passed and which (if any) failed.</li>
</ol>
