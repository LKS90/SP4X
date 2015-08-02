<!---#COMMENT_BEGIN

How to links inside document (using HTML tags + .md-links):

    Anchor element   ---|    <a name="ANCHOR"/>

    Link in summary  ---|    [link text](#ANCHOR)
    
    An issue template is at the end of the issue list.

COMMENT_END#-->

<a name="top"/></a>

To do
=====
- [[#5: Instantiate some tiles]](#issue-5)
- [[#6: Create an interface for GroundTile interaction.]](#issue-6) [CURRENT]  
***

Done
====
- [[#1: Rename Model-GameObjects to sane names]](#issue-1)  
- [[#2: Add WorldBuilder Interface for all objects which are used in WorldBuilder]](#issue-2)  
- [[#3: Move the Model-GameObject creation completly to sub-classes]](#issue-3)
- [[#4: Refactor switch statement into simpler construction block of default objects]](#issue-4)
- [[#7: Git init the project]](#issue-7)
- [[#8: Set up project for portabilty.]](#issue-8)
- [[#9: Clean up .md files]](#issue-9)
***
***

Issue List
==========

***
<a name="issue-1"/>
[[-go to top-]](#top)
  
**Issue #1:** Rename Model-GameObjects to sane names
  
**Description:**  I renamed all prefabs to sane names.

**SCHEMA** - *{OBJECT-TYPE}*.*{SUB-TYPE}*.*{COMPONENT}*
    
examples:  
```
ground.basic.mesh  
flower.red_1.petal_3.mesh    
rock.medium_1.mesh       
```
***
<a name="issue-2"/>
[[-go to top-]](#top)
  
**Issue #2:** Add WorldBuilder Interface for all objects which are used in WorldBuilder 
 
**Description:**  
All objects (ground, flower, rock, etc.) should implement a WorldBuilderInterface.  
Methods for initialisation and interaction (init(), update()) are needed. 

**Related:**

NONE (YET) 

***
<a name="issue-3"/>
[[-go to top-]](#top)
  
**Issue #3:** Move the Model-GameObject creation completly to sub-classes 
 
**Description:**  
The WorldBuilder start() method currently gets all types by iterating over 
the world object. WorldBuilder should be able to create a new Type without  
and expect it to have it ready for use.  

**Related:**

NONE (YET) 

***
<a name="issue-4"/>
[[-go to top-]](#top)
  
**Issue #4:** Refactor switch statement into simpler construction block of default objects 
 
**Description:**  
When [Issues #2](#issue-2) and [Issue #3](#issue-3) are finished, the switch statement can be replaced  
with a simple, non-branching creating block.  

**Related:**

[#2: Add WorldBuilder Interface for all objects which are used in WorldBuilder](#issue-2)  
[#3: Move the Model-GameObject creation completly to sub-class](#issue-3) 

***
<a name="issue-5"/>
[[-go to top-]](#top)
  
**Issue #5:** Instantiate some tiles 
 
**Description:**  
Start creating some groundwork for the world generation.
Add some tiles, expand them, save them in some useful structure.

**Related:**

NONE (YET)

***
<a name="issue-6"/>
[[-go to top-]](#top)
  
**Issue #6:** Create an interface for GroundTile interaction.
 
**Description:**  
An interface to interact with the GroundTiles would be nice.

**Related:**

NONE (YET)

***
<a name="issue-7"/>
[[-go to top-]](#top)
  
**Issue #7:** Git init the project
 
**Description:**  
After some tedious issues, I'd love to have some version control system.

**Related:**

- [[#8: Set up project for portabilty.]](#issue-8)

***
<a name="issue-8"/>
[[-go to top-]](#top)
  
**Issue #8:** Set up project for portabilty.
 
**Description:**  
Cloned the repository with my Surface and set up everything.
Now only changes that are relevant to the project are tracked
and Visual Studio 13, 15 and Code as well as Unity 5.1.1/5.1.2
can be used for editing.

**Related:**

- [[#7: Git init the project]](#issue-7)

***
<a name="issue-9"/>
[[-go to top-]](#top)
  
**Issue #9:** Clean up .md files
 
**Description:**  
Had a look at the markdown files on github, fixed some inconsistencies
that Github seems to have. Also added some information about editing tools
to the readme and added a templates to the todo.md comment.

**Related:**

NONE (YET)

***

<!---#TEMPLATE_BEGIN
[@ISSUE_TEMPLATE]
{
    <a name="issue-{{@ISSUE_ID}}"/>
    [[-go to top-]](#top)
  
    **Issue #{{@ISSUE_ID}}:** {{@TITLE}}
 
    **Description:**  
    {{@DESCRIPTION}}

    **Related:**

    {{@RELATED_ISSUES}}

    ***
}
TEMPLATE_END#-->
