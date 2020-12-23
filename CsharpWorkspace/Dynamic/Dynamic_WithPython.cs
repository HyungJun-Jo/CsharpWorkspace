using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace Dynamic
{
    // C# 에서 Python을 사용하는 방법
    // 1. ironPython 설치 (https://github.com/IronLanguages/main/releases)
    // 2. 설치폴더에 있는 dll 파일을 모두 참조
    // 3. 아래 방식으로 활용 
    // - 자세한 내용은 github에 첨부된 샘플 또는 뇌자C# 518page 참고
    class WithPython
    {
        static void Main()
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-4566");
            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard:
    name = ''
    phone = ''

    def __init__(self, name, phone):
        self.name = name
        self.phone = phone

    def printNameCard(self):
        print(self.name + ',' + self.phone)

NameCard(n, p)
");
            dynamic result = source.Execute(scope);     // 앞의 파이썬 코드 실행, NameCard 객채가 생성되어 반환.
            result.printNameCard();                     // 객체의 메소드를 호출도 가능하며

            Console.WriteLine("{0}, {1}", result.name, result.phone);       // 필드에도 접근 가능
            Console.ReadLine();
        }
    }
}
