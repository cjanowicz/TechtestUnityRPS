# TechtestUnityRPS
 September 25th 2021:
My primary objectives will be to demonstrate my working knowledge of skills useful for
a QA Engineer.

Todo:
Make a Unit test for the EnemyHand AND Playerhand outputting valid choices.
Make a Unit test for the proper results of a match.
Make a unit test for the money being incremented or decremented properly.

Stretch goals:
Export unit test results to a report that can be exported and uploaded.

September 27th 2021:

I created unit tests in EditMode and PlayMode. The EditMode 
test I created unit tests all the possible
outcomes of the rock paper scissors matchup, and confirms that the
results of a match are as expected. The PlayMode test simulates
hundreds of matches and checks for invalid text being output
onto the screen. 

I designed the PlayMode test to catch the error of the EnemyHand being
"Nothing", and creating an invalid match. I was not sure how to catch it 
 with an EditMode test, but I would love to discuss that if we can
 have the time.

My EditMode unit tests are a little ugly and full of repetition, and
if I had more time I would have made the code more elegant and easy
to read. Though I am not sure if it is better for the unit tests
to be broken up in function name, so that all 9 checks are run, and
the failure and success of each one is reported.

I glad to report that I have created a Jenkins build machine that creates
a playable build of the game, but also generates the results.xml file
from the automated tests added to the game using the test runner window.

I decided to shoot for having a JenkinsBuild machine to create builds, 
as well as automatically run the unit tests in the game, primarily because
I remember in the phone interview that we had, that JenkinsBuild was
mentioned as a useful bonus skill. Also, it would be inconvenient for
developers to manually run the unit tests themselves, and it simplifies 
the process for the build machine to automatically run the tests for them.

I didn't write the JenkinsBuild.cs script, and only edited it a small bit
to fix an issue that I saw. I have credited them in the comments.

I have included a folder in the project called "ReadmeFiles" with a copy 
of a build made by jenkins (#15. Builds 1-8 were failures, builds 9-14 were
successes, 15 was the first one to successfully run and output the unit
test results), as well as a copy of the workspace folder found in 
C:\Windows\System32\config\systemprofile\AppData\Local\Jenkins\.jenkins\workspace

I wasn't quite sure how else to show my work in creating the jenkinsbuild machine,
or how it can be maintained with version control, but I would love
to talk about it sometime. 

Anyways, if I had more time, I would have:
Implemented unit tests to check that the money increment/decrement 
functions were working properly. As some of that code was in private
functions, I was a little stuck and decided to focus on the build
machine instead.
