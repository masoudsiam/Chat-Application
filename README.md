# Chat-Application
In this project I made a chatting application.
Since it was my advanced programming course project I didn't use servers so it is not going to send and receive data over internet and uses local storage of your system for saving and loading data.
But if you want to develop this project to use servers you can easily doing this by just changing a few functions defined in classes with the suffix "SaveLoad".
I designed the program using visual studio and I also used bunifu framwork which adds a lot of beautiful and powerful controls to your visual studio toolbox.If you want to open this project in your visual studio you need to install bunifo on your visual studio too.

## Features
Features provided in this application are inspired from Telegram.Here is a brief list of these features:

1- You can have up to 3 accounts connected to the application.

2- You can add or remove contacts from your contact list.

3- You can create groups and channels with the ability of adding people or removing them and also promoting and demoting their rank.

4- owner of a group or channel can remove anyone while admins can only remove members.

5- In channels only owner and admins can post a message.

6- You can send text and image as your message.

## Classes
there are about 20 classes in this program which can be categorized in the following groups:

1- Classes with "SaveLoad" suffix.these classes use BinaryFormatter to save or load the specified data.

2- Classes with "BasicOperation" suffix.these classes formed of really basic operations which almost never used directly in the design files.

3- Classes with "Managment" suffix.these classes formed of functions with more specific usage which used in the design files.

4- Classes with "Editable" suffix.I used interface for contacts, channels and groups.Since contacts were diffrenet in some special cases with groups and channels I used "Editable" classes
to define some functions only for groups and channels.I didn't have to do this and its purpose is only for easier access to these functions and cleaner coding style.

5- There are also other classes in this project which are easy to understand by reading them yourself.
