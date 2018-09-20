# treeSharp
A fake tree program to fool tech scammers.

## What is it?

treeSharp is a fake tree command that, when a letter is pressed on the keyboard, slows down by 25ms per line. Once 200 characters have been entered, it stops and says "System clean. No viruses or hackers detected.".

The name comes from the original program (tree) and the flavour of C this is written in: sharp. Such comes treeSharp.

## Installation

#### Taking ownership of and renaming tree
1. Download the release of your choices.
2. Open a file explorer window and go to `C:\Windows\System32`. Then, select a single file and type in `tree`. That should take you to the tree file.
3. Right click it and select Properties...
4. Click the security tab
5. Click Advanced...
6. Change the owner to yourself
7. Apply and close
8. Click Administrators (`YOUR-PC-NAME\Administrators`) in Group or user names
9. Click Edit...
10. Click Administrators again
11. Tick Full control at the bottom
12. Apply and close this window and the properties window
13. Right click on tree and rename it to something like `tree-ori`.

#### Adding our app
14. Grab the treeSharp.exe file from releases, and drag it into this folder (System32)
15. Right click on treeSharp, and rename it to `tree`.

Done!

## Usage

Once following the installation steps, just open cmd and type `tree` and press enter.

## Differences between the real tree and treeSharp

- The real tree actually shows real stuff from your computer
- Much smaller (ours is about 4MB the original is 4KB)
- While scammers can type into treeSharp, each character they type makes the lines 25ms slower.
- Once 200 characters are typed into treeSharp, it will stop and print out what the scammer typed in tree, in reverse, in a fake tree prompt. See screenshots for examples.
