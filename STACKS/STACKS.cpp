// STACKS.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stack>
using namespace std;

int main()
{
    //Stacks *******************************************
    //LIFO (LAST-IN FIRST-OUT) data structure
    //Ex: A stack of books (object)
    //**************************************************

    stack<string> stack;

    //push() to add to the top
    stack.push("Minecraft");
    stack.push("Skyrim");
    stack.push("DOOM");
    stack.push("Borderlands");
    stack.push("FFVII");

    //pop() to remove from the top,
    //it also returns the element value which can be assigned to a variable
    //stack.pop();

    //top() to return the topmost element without removing it
    std::cout << stack.top() << endl;


    //empty() to determine whether stack is empty or not
    std::cout << stack.empty();

    //size() to return the number of elements in stack
    std::cout << stack.size();

    //STACK CANNOT BE TRAVERSED!
    //but it can be looped through but the stack will be empty by the end of the loop
    while (stack.size() > 1) {
        std::cout << stack.top() << endl;
        stack.pop();
    }

    return 0;
}

//USES OF STACKS
/*
* 1. Undo/redo features in text editors
* 2. Go back and forth through browser history
* 3. Task scheduling
* 4. Backtracking algorithms (e.g., maze, file directories)
* 5. Calling functions (call stack)
* 6. DPS (Depth-first search)
*/
