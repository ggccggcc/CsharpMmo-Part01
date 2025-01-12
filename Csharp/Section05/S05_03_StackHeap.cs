using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Section05
{
    internal class S05_03_StackHeap
    {
        //스택 메모리, 힙 메모리

        // 스택은 불안정 - 임시로 사용 하는 곳
        // 함수를 쓰는데 임시로 쓰는 메모장 같은 개념

        // 복사되는 타입(구조체)는 메모리에 본체가 들어감
        // 참조형은 본체가 아니라 주소가 들어감 : 본체가 있는 주소
        // 본체는 HEAP에 있음, 참조는 주소가 ---> HEAP으로 안내하는 것임
        // 스택은 주소가 아니라 그냥 본체 자체를 가리킴

        // Knight knight = new Knight(); 이거는 HEAP 영역에 새로운 본체를 복사하는 것임 - 클래스를 새로 만든다
        // Knight k = knight;는 기존의 knight를 가리키는 새로운 중개 주소를 만드는 것임(사서함, 중개거래용 계좌번호 개념) 




        // 
    }
}
