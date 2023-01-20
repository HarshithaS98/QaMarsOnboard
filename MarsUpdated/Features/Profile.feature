Feature: Profile


As a Seller , I would like to create my Profile information
so that people seeking for some skills can look into my profile

Background: Logging in to portal
    Given The user is logged in to portal

Scenario Outline: create new Skill
    When User adds a '<Skill>' and a '<SkillLevel>'
    Then '<Skill>' and '<SkillLevel>' should be added successfully

    Examples: 
    | Skill    | SkillLevel   |
    | Java    | Beginner     |
    | Selenium | Expert       |
    | C#       | Intermediate |

    Scenario Outline: Create new Language
    When User adds a '<Language>' and  '<Level>'
    Then  '<Language>' and '<Level>'   language created sucessfully    
    Examples: 
    | Language | Level          |
    | English  | Fluent         |
    | Mandarin | Conversational |
    