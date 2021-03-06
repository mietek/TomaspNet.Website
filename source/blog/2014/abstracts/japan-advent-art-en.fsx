﻿(**
<div id="myModal" class="reveal-modal xlarge" data-reveal>
  <iframe src="http://tomasp.net/blog/2014/japan-advent-art-en/hokusai.html" style="width:100%; height:850px;border-style:none;"></iframe>
  <a class="close-reveal-modal">&#215;</a>
</div>

<div class="rdecor" style="text-align:center">
<a href="#" data-reveal-id="myModal" style="text-align:center">
<img src="http://tomasp.net/blog/2014/japan-advent-art-en/hokusai_sm.jpg" style="margin-bottom:10px;border:4px solid black" title="The Great Wave off Kanagawa" /><br />
<small style="font-size:90%">Click here to see the result live!</small>
</a>
</div>

For the last few years, the Japanese F# community has been running the F# Advent Calendar 
([2010](http://atnd.org/events/10685), [2011](http://partake.in/events/1c24993a-c475-4fc2-bca4-7a1cd2f81869), [2012](http://atnd.org/events/33927)). 
Each advent day, one person writes an article about something interesting in F#. I have 
been following the advent calendar last year on Twitter and when the planning started for 
this year, I offered to write an article too. You might have noticed that I posted a 
[Japanse version of the article](http://tomasp.net/blog/2013/japan-advent-art/index.html)
in December as part of the [advent calendar 2013](http://connpass.com/event/3935/).

A number of people helped to make this happen - [@@igeta](http://twitter.com/igeta) arranged everything and 
helped with reviewing, [@@yukitos](http://twitter.com/yukitos) translated the article and 
[@@gab_km](http://twitter.com/gab_km) reviewed the translation. Thanks!

But what should I write about? It would be nice to look at some of the F# open-source libraries
and projects that have been developing over the last year in the F# community. At the same time,
can I relate the topic of the article to Japan? After some thinking, I came up with the following
plan:

 * First, we'll use the [F# Data][fsdata] library and the [Freebase](http://www.freebase.com) to learn
   something about Japanese art. I should add that thanks to [@@yukitos](https://twitter.com/yukitos) the library now also has 
   a [documentation in Japanese][fsdatajp].

 * Then we'll pick one art work and try to recreate it in F#. Given my artistic skills, this 
   part will definitely fail, but we can try :-).

 * Finally, we'll use the [FunScript project](http://funscript.info) to turn our F# code into
   JavaScript, so that we can run it as a pure HTML web application that also works on mobile
   phones and other devices.

[fsdata]: http://fsharp.github.io/FSharp.Data/
[fsdatajp]: http://fsharp.github.io/FSharp.Data/jp
*)