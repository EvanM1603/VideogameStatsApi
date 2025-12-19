# VideogameStatsApi


## Brief:

**Specifications:**

You are required to design and build an API service(s), or microservice(s), that adheres to Service
Oriented Architecture principles, using an ASP.NET Core based framework. You can choose to use REST,
or GraphQL (or suitable alternative – to be agreed with your lecturer). This should be a Design-First effort
where use cases and acceptability cases are defined.
The services should be based around a CRUD pattern. 

**Requirements:**

**1.** There should be a minimum of 4 types of services i.e., complete CRUD.

**2.** Some type of identity management/authentication should be used, appropriate to your services.
Consider login and/or API key generation.

**3.** The data should use some form of persistent storage and avail of modern Design Patterns and
Software Engineering principles. There should be a minimum of 3 tables using at least one oneto-many relationship. Separation of data storage should be achieved via interfaces and data
returned to the client should be different than the data in the persistent storage i.e., use
appropriate DTOs.

**4.** The service should be deployed on the Internal DKIT cloud-based server infrastructure or on an
external Cloud based Service (e.g., Azure, AWS).

**5.** Testing: The Api should be tested and demonstrated using use cases with POSTMAN commands;
the project should also contain appropriate unit tests. 

**6.** Any extra facilities researched and added e.g., simple mobile client.


## References:

Used this video as a reference to help create CRUD functionality - https://youtu.be/RwQVRXEs370?si=s3HEMqBS7Au1krrb

Used this video to help add Authentication - https://youtu.be/0mb-wkkVMbg?si=dmaLMZjuJ5Fnro4o 

Used to help deploy to cloud - https://youtu.be/F33QoaG4ufE?si=dZcNn_uPNtJi6xcx

Deployed App - https://videogamestatsapp-evan-e6a7e0hzcbfrdeav.westeurope-01.azurewebsites.net/api/games

## Known Issues:

Getting an error 500 on deployment when trying to use with postman, not sure what the issue is.

## Tested CRUD:

**Tested Create:** <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/98ec81e9-0d12-49e9-8c92-3417d4949d3f" />

**Tested Read:** <img width="1917" height="1079" alt="image" src="https://github.com/user-attachments/assets/c534a5a5-c0dd-4293-9781-b51c90f076f3" />

**Tested Update:** <img width="1917" height="1079" alt="image" src="https://github.com/user-attachments/assets/558f6e3a-d498-4924-8ad5-1223d42fd13a" />

**Tested Delete:** <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/1a7eb324-6846-4ca0-91fb-8e3975c5a4bf" />


## Tested Authentication:

**Tested with the Right API Key:** <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/25a9aad8-6abd-44c3-9280-f9d9a8ffc3d8" />

**Tested with the Wrong API Key:**  <img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/70c09c5a-60c5-4c31-883c-f6415d1f3e24" />

**Tested with No API Key:**  <img width="1917" height="1079" alt="image" src="https://github.com/user-attachments/assets/c06422ba-faae-4213-8b0f-275c38433df0" />
