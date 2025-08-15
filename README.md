Programming assignment: Robot programming
 Your solution to this programming assignment will form the basis of the conver
sation during the technical interview. Highlight what you are good at. If you
 feel certain parts could have been resolved better if you had more time, then
 comment on that too.
 We ask you to deliver the solution in the same quality as you would provide a
 delivery to a customer. Please include a README file in your solution, with
 any steps necessary to run both the app and the test cases.
 If you want to give us a bit more insight into your development process, please
 include your entire Git repository, so that we can follow your commit log and
 see how your solution came to be.
 Feel free to use any framework and language you are comfortable with that you
 think is well suited for this task, but do not use any tools or third party code to
 implement any essential or major part of the assignment. Your solution should
 contain unit tests, at least for the most critical logic, using a test framework of
 your choice. If you have time and want to add more types of test cases, that’s a
 plus.
 We will look at all aspects of the code including things like formatting, commit
 messages, usage of language/framework features, architecture and error handling.
 Task: Robot programming
 Your task is to program the controller to a robot. It’s a simple robot that can
 walk around in a room where the floor is represented as a number of fields in a
 wire mesh. Input is first two numbers, which tells the robot how big the room is:
 5 7
 Which means that the room is 5 fields wide and is 7 fields deep.
 The size of the room follows two digits and one letter indicating the starting
 position of the robot and its orientation in space. For example:
 1
3 3 N
 Which means that the robot is in field (3, 3) and faces north. Subsequently, the
 robot receives a number of navigation commands in the form of characters. The
 following commands shall be implemented:
 • LTurn left
 • RTurn right
 • FWalk forward
 Example:
 LFFRFRFRFF
 If the robot walks outside of the room bounds an appropriate the program should
 exit with an error code.
 After the last command is received, the robot must report which field it is in
 and what direction it is facing.
 Example:
 5 5
 1 2 N
 RFRFFRFRF
 Report: 1 3 N
 5 5
 0 0 E
 RFLFFLRF
 Report: 3 1 E
