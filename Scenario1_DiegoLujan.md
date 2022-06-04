Scenario 1:
You are brought on to help with the latest LFL VR masterpiece that has already been in
development for 6 months. Your support will help take it from a working alpha to a feature
complete beta. You are familiar with the functionality as you have played around with the
experience casually and even understand the overall structure from a few offsite lunches with
the lead engineer. After being assigned a few “simple” bugs you get to work. Immediately, you
realize a core piece of code that can be improved for efficiency is being used throughout the
project and has been in the code base for almost 5 months.
● Questions:
○ How would you attempt to understand the design of a large code base in a short
period of time?
Answer: 
First, i would take notes for initializer, loaders, hierarchy class, dependencies between class, scripts used as utilities, scene dependencies , libraries not used. Second i would try select funcionalities than can be partitioned to follow de design principle of single responsability & segregation. Then i would create a branch of testing of the posible solution and finally with the results i can be sure the grade of complexity of the large code base.

○ What steps will you take to understand the ramifications of the potential refactor?
Answer:
Research of the metrics expected for the task and the refactor.
Add some piece of data analytic collector to help with the research.
Determinated what techniques or design it would need.
Estimate the effort needed.
Make experimental to validate the necessity of refactor.

○ How do you balance the task of fixing the bug with the investigation?
Answer:
To balance these tasks , i would need to made two branch, one for bug fixing and the other for refactor, the refactor branch i would made extra branch for experimental. I would applied the design principle of Solid in the bug fixing task and made this my priority. When submiting i would merge with the refactor branch. Then i would use this branch and create experimental branch when try to refactor the core of the app. 