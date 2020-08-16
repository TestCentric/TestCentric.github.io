Title: About TestCentric
---

The name comes from the phrase "Test-Centric Development," a term I use when working with
software teams. It describes an approach where pretty much everything a team does has a test of
some kind behind it, ranging from micro-tests of the software to more subjective "tests" that
help us decide what engineering practices work best for us.

In addition to working with teams and conducting training, the TestCentric group is focused on
developing tools and techniques that support that approach to software development. Currently,
all the TestCentric tools are Open Source, although there may be commercial versions of some of
them in the future.

# About Me

I'm Charlie Poole and I've worked in software development since the 1970s. In 2001 I came across Extreme Programming and in particular Test-Driven Development. I was involved in the NUnit project
beginning around 2002 and still have some involvement today.

Much of the tooling that I'm hoping to create will leverage my own work on NUnit but will hopefully go beyond what has been done before.

# Software

## TestCentric GUI Runner

NUnit V2 came with a GUI runner in addition to the console runner. Beginning with NUnit 3,
no GUI runner is provided. The TestCentric Runner fills that need.

The 1.x releases of the GUI look and work very much like the NUnit V2 GUI. Of course, they support NUnit 3 tests and - using the standard NUnit extension - NUnit V2 tests as well.

Documentation for the TestCentric Runner is available [here](/testcentric-gui).

## Experimental GUI Runner

A separate Experimental GUI runner is being developed in conjunction with the standard runner. It departs significantly in appearance and function from the version 1 GUI. It will eventually be released as a major upgrade of the TestCentric Runner, version 2.0 or higher.

Currently, the experimental GUI is included in our packages but is considered as pre-alpha software.

## TC-Lite Test Framework

TC-Lite is a lightweight test framework in the spirit of NUnitLite, aimed at the creation and
execution of fast, independent micro-tests. Tests are self-executing, being incorporated in an
executable assembly, and require no additional infrastructure beyond the framework itself.

Work on TC-Lite is ongoing. Documentation for what has been implemented so far is available [here](/tc-lite).

<!-- ## TestCentric Framework

This is still on the drawing board, so I won't say much about it.

Generally, I'm thinking of carrying forward some of NUnit's syntactic innovations in a slightly expanded form and separating the assertion facility from the test framework itself. I would also like to allow users to choose among alternate sets of features for different kinds of testing - micro-tests versus functional testing, for example.

Many of the ideas that have been germinating around this new framework were nurtured by folks in the Lonely Coaches Sodality group.

## TestCentric Extension for Visual Studio

This is a bit more futuristic and will build on the experimental GUI to create a true VS extension (not an adapter) for running tests. This will allow the user to have the same views of tests either within VS or in a standalone GUI.

I have not yet decided whether this will be Open Source, commercial or dual-licensed using two different versions.

## TestCentric Test Engine

I'll be evaluating whether the NUnit engine can be used to carry out all the goals of the other projects. If necessary, a separate engine will be created. -->