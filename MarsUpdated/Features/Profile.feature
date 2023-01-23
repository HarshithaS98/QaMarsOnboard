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
    
    Scenario Outline: User create certifications using certification tab
    When Added '<Certificate>' and '<From>' and '<Year>'  to the Certifications
    Then   '<certificate>' and '<From>' and '<Year>'  created successfully
    Examples: 
    | Certificate | From            | Year    |
    | ISTQB       | SGTQB           | 2022    |
    | API         | INDUSTRYCONNECT | 2023|

    
   #Scenario Outline: User edited existing certificate details with valid details
   #Given edited '<certificate>' and '<Year>' and '<From>'  to the Certifications
   #Then the '<certificate>' and '<Year>' and '<From>'  to the Certifications edited successfully

 #Examples: 
 #| certificate  | From             | Year | 
  #Scenario: User able to delete edited certificate details  with valid details
  #Given Deleted '<certificate>', '<Year>' , '<From>'  to the Certifications
  #Then the '<certificate>' , '<Year>' , '<From>'  to the Certifications  deleted successfully


 #All The Testcases for profile page
#Scenario:Verify validation error for certification
#When Lefted '<certificate>' and <Year> and <From>  to the Certificationsnot choosen or when duplicate data exists
#Then error message should be displayed

#Scenario Outline: User writes  description using description tab
#When When Added <description>  to the description
#Then the <description>   created successfully

 #Examples: 
 #| Description                                                            |  
 #| Iam Harshitha, I would like to say that Iam a Qa Intern at MvP studios |


#Scenario Outline: User edited existing description details with valid details
#When edited<description>  to the description
#Then the<description>  to the description edited successfully

 #Examples: 
 #| Description                                                                      |
 #| Iam Harshitha, I would like to say that Iam a Test analyst Intern at MvP studios |

#Scenario: User able to delete edited description details
#When Deleted <description>  to the description
#Then the <description>  to the description deleted successfully

#Scenario:Verify validation error for description
#When Lefted  <description> not choosen or when duplicate data exists
#Then error message should be displayed


#Scenario Outline: User create Education using education tab
#When When Added <country> and <University> and <Title> <Degree> <Graduation year> to the education
#Then the <country> and <University> and <Title> <Degree> <Graduation year> created successfully

 #Examples: 
 #| country | University | Title | Degree    | Graduation year |
# | India   | JNTU       | Btech | Bachelors | 2013            |


#Scenario Outline: User edited existing education details with valid details
#When edited<country> and <University> and <Title> <Degree> <Graduation year> to the education
#Then the<country> <University>  <Title> <Degree> <Graduation year>  edited successfully

#Examples: 
#| country   | University          | Title | Degree  | Graduation year |
#| Singapore | National University | MS    | Masters | 2020            |

#Scenario: User able to delete edited education  with valid details
#When Deleted <country> and <University> and <Title> <Degree> <Graduation year> to the education
#Then the <country> <University> <Title> <Degree> <Graduation year>  deleted successfully

#Scenario:Verify validation error for education
#When Lefted <country> and <University> and <Title> <Degree> <Graduation year> not choosen or when duplicate data exists
#Then error message should be displayed