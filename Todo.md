[//]: # (@TITLE: SP4X)
[//]: # (@INFO: Issue tracker - )
[//]: # (#SUMMARY_BEGIN)
To do <a name="top"/></a>
=====
- [[#5: Instantiate some tiles]](#issue-5)
- [[#6: Create an interface for GroundTile interaction.]](#issue-6) [CURRENT]  

Done
====
- [[#1: Rename Model-GameObjects to sane names]](#issue-1)  
- [[#2: Add WorldBuilder Interface for all objects which are used in WorldBuilder]](#issue-2)  
- [[#3: Move the Model-GameObject creation completly to sub-classes]](#issue-3)
- [[#4: Refactor switch statement into simpler construction block of default objects]](#issue-4)
- [[#7: Git init the project]](#issue-7)
- [[#8: Set up project for portabilty.]](#issue-8)
- [[#9: Clean up .md files]](#issue-9)
[//]: # (#SUMMARY_END)
[//]: # (#ISSUE_LIST_BEGIN)
Issue List
==========

[//]: # (-ISSUE_ID: 1)
[//]: # (-TITLE: 'Rename Model-GameObjects to sane names')
[//]: # (-DESCRIPTION[]: 'I renamed all prefabs to sane names./n **SCHEMA** - *{OBJECT-TYPE}*.*{SUB-TYPE}*.*{COMPONENT}*')
[//]: # (-EXAMPLES: ['ground.basic.mesh', 'flower.red_1.petal_3.mesh', 'rock.medium_1.mesh'])
***
<a name="issue-1"/>
[[-go to top-]](#top)
  
**Issue #1:** Rename Model-GameObjects to sane names
  
**Description:**  I renamed all prefabs to sane names.

**SCHEMA** - *{OBJECT-TYPE}*.*{SUB-TYPE}*.*{COMPONENT}*
    
**EXAMPLES**:  
```
ground.basic.mesh  
flower.red_1.petal_3.mesh    
rock.medium_1.mesh       
```

[//]: # (@ISSUE_ID: 2)
[//]: # (@TITLE: 'Add WorldBuilder Interface for all objects which are used in WorldBuilder')
[//]: # (@DESCRIPTION[1]: 'All objects (ground, flower, rock, etc.) should implement a WorldBuilderInterface.')
[//]: # (@DESCRIPTION[2]: 'Methods for initialisation and interaction (init(), update()) are needed.')
***
<a name="issue-2"/>
[[-go to top-]](#top)
  
**Issue #2:** Add WorldBuilder Interface for all objects which are used in WorldBuilder 
 
**Description:**  
All objects (ground, flower, rock, etc.) should implement a WorldBuilderInterface.  
Methods for initialisation and interaction (init(), update()) are needed.

[//]: # (@ISSUE_ID: 3)
[//]: # (@TITLE: 'Move the Model-GameObject creation completly to sub-classes')
[//]: # (@DESCRIPTION[1]: 'The WorldBuilder start() method currently gets all types by iterating overthe world object.')
[//]: # (@DESCRIPTION[2]: 'WorldBuilder should be able to create a new Type without/nand expect it to have it ready for use.')
[//]: # (@DESCRIPTION[3]: 'and expect it to have it ready for use.')
***
<a name="issue-3"/>
[[-go to top-]](#top)
  
**Issue #3:** Move the Model-GameObject creation completly to sub-classes 
 
**Description:**  
The WorldBuilder start() method currently gets all types by iterating over 
the world object. WorldBuilder should be able to create a new Type without  
and expect it to have it ready for use.

[//]: # (@ISSUE_ID: 4)
[//]: # (@TITLE: 'Refactor switch statement into simpler construction block of default objects')
[//]: # (@DESCRIPTION[1]: 'When [Issues #2](#issue-2) and [Issue #3](#issue-3) are finished, the switch statement can be replaced')
[//]: # (@DESCRIPTION[2]: 'with a simple, non-branching creating block.')
[//]: # (@RELATED_ISSUES[1]: 2)
[//]: # (@RELATED_ISSUES[2]: 3)
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

[//]: # (@ISSUE_ID: 5)
[//]: # (@TITLE: 'Instantiate some tiles')
[//]: # (@DESCRIPTION[1]: 'Start creating some groundwork for the world generation.')
[//]: # (@DESCRIPTION[2]: 'Add some tiles, expand them, save them in some useful structure.')
***
<a name="issue-5"/>
[[-go to top-]](#top)
  
**Issue #5:** Instantiate some tiles 
 
**Description:**  
Start creating some groundwork for the world generation.
Add some tiles, expand them, save them in some useful structure.

[//]: # (@ISSUE_ID: 6)
[//]: # (@TITLE: 'Create an interface for GroundTile interaction.')
[//]: # (@DESCRIPTION[1]: 'An interface to interact with the GroundTiles would be nice.')
***
<a name="issue-6"/>
[[-go to top-]](#top)
  
**Issue #6:** Create an interface for GroundTile interaction.
 
**Description:**  
An interface to interact with the GroundTiles would be nice.

[//]: # (@ISSUE_ID: 7)
[//]: # (@TITLE: 'Git init the project')
[//]: # (@DESCRIPTION[1]: 'After some tedious issues, I'd love to have some version control system.')
[//]: # (@RELATED_ISSUES[1]: 8)
***
<a name="issue-7"/>
[[-go to top-]](#top)
  
**Issue #7:** Git init the project
 
**Description:**  
After some tedious issues, I'd love to have some version control system.

- [[#8: Set up project for portabilty.]](#issue-8)

[//]: # (@ISSUE_ID: 8)
[//]: # (@TITLE: 'Set up project for portabilty.')
[//]: # (@DESCRIPTION[1]: 'Cloned the repository with my Surface and set up everything.')
[//]: # (@DESCRIPTION[2]: 'Now only changes that are relevant to the project are tracked')
[//]: # (@DESCRIPTION[3]: 'and Visual Studio 13, 15 and Code as well as Unity 5.1.1/5.1.2')
[//]: # (@DESCRIPTION[4]: 'can be used for editing.')
[//]: # (@RELATED_ISSUES[1]: 7)
***
<a name="issue-8"/>
[[-go to top-]](#top)
  
**Issue #8:** Set up project for portabilty.
 
**Description:**  
Cloned the repository with my Surface and set up everything.
Now only changes that are relevant to the project are tracked
and Visual Studio 13, 15 and Code as well as Unity 5.1.1/5.1.2
can be used for editing.

- [[#7: Git init the project]](#issue-7)

[//]: # (@ISSUE_ID: 9)
[//]: # (@TITLE: 'Clean up .md files')
[//]: # (@DESCRIPTION[1]: 'Had a look at the markdown files on github, fixed some inconsistencies')
[//]: # (@DESCRIPTION[2]: 'that Github seems to have. Also added some information about editing tools')
[//]: # (@DESCRIPTION[3]: 'to the readme and added a templates to the todo.md comment.')
***
<a name="issue-9"/>
[[-go to top-]](#top)
  
**Issue #9:** Clean up .md files
 
**Description:**  
Had a look at the markdown files on github, fixed some inconsistencies
that Github seems to have. Also added some information about editing tools
to the readme and added a templates to the todo.md comment.

***
[//]: # (#ISSUE_LIST_END)

[//]: # (#ISSUE_TEMPLATE_BEGIN)
[//]: # ('<a name="issue-{@ISSUE_ID}"/>')
[//]: # ('[[-go to top-]](#top)')
[//]: # ('')
[//]: # ('**Issue: #{@ISSUE_ID}:** {@TITLE}')
[//]: # ('')
[//]: # ('**Description:**')
[//]: # ('{@DESCRIPTION}')
[//]: # ('')
[//]: # ('**Related:**')
[//]: # ('')
[//]: # ({@RELATED_ISSUES})
[//]: # ('')
[//]: # ('***')
[//]: # (#ISSUE_TEMPLATE_END)
