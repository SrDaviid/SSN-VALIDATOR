# Test Plan

### Positive 
|Description| Imput| Result| 
|:--------------------:|:------------:|:----------:|
|In the first 3 digits the user introduce digits between 900 and 999|920-32-3423|Your SSN is valid|
|In the second part the user introduce 2 digits between 01 to 99|945-76-5423|Your SSN is valid|
|In the third part the user introduce 4 digits between 0001 to 9999|983-32-8754| Your SSN is valid|


### Negative
|Description| Imput| Result| 
|:--------------------:|:------------:|:----------:|
|The user introduce more than 9 digits (hyphen include)|909-4344-4343|The length is not correct|
|In the first part the user introduce digits like 000 and 666|000-43-4332|Your SSN is not valid|
|In the second part the user introduce digits that is not between 01 to 99| 950-00-4323|Your SSN is not valid|
|In the third part the user introduce digits that is not between 0001 to 9999|943-65-0000|Your SSN is not valid|




