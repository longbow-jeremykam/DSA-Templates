// QUEUES.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <queue>
using namespace std;

//Queue *************************************************
//FIFO (FIRST-IN, FIRST-OUT) linear data structure
//A collection to hold elements before processing
//Ex: The waiting line at the checkout counter

/*
* To add to queue,
*      .push()
// Adds an element at the tail of the queue

* To remove from queue,
*      .pop()
*/
// Removes an element at the head of the queue
//*******************************************************

//printing the queue through while loop but the queue will be empty by the end of the loop
void showq(queue<string> gq)
{
    queue<string> g = gq;
    while (!g.empty()) {
        cout << ' ' << g.front() << endl;
        g.pop();
    }
    cout << '\n';

    gq.swap(g);
}

int main()
{
    queue<string> queue;

    queue.push("Karen");
    queue.push("Chad");
    queue.push("Steve");
    queue.push("Harold");

    //pop() to remove the topmost element,
    //it also returns the element reference which can be assigned to a variable
    //queue.pop();
    
    //front() to return the topmost element without removing it
    //std::cout << queue.front() << endl;

    //back() to return the bottommost element without removing it
    //std::cout << queue.back();

    //printing the queue
    showq(queue);
    
    //.size() will return the number of elements in the queue
    std::cout << queue.size() << endl;

    //.empty() will return a truth value on whether the queue is empty
    std::cout << queue.empty() << endl;
}

//USES OF QUEUES
/*
 * 1. Keyboard buffer (letters should appear on the screen according to the order they're pressed)
 * 2. Print Queue
 * 3. Found also in LinkedLists, PriorityQueues, BFS (breadth-first search)
 */
