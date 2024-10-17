To allow only users with a valid code to sign up using Microsoft Entra ID (formerly Azure AD) with self-service sign-up, you can implement an invitation-based system. This approach ensures that only users who have received a valid invitation code can complete the sign-up process. Here's how you can do it:

### Steps to Implement Invitation-Based Sign-Up

1. **Generate Invitation Codes**:
   - Create a system to generate unique invitation codes. These codes can be stored in a secure database along with their status (used or unused).

2. **Distribute Invitation Codes**:
   - Distribute these codes to users who are allowed to sign up. This can be done via email or any other secure communication method.

3. **Customize User Flow**:
   - Customize the self-service sign-up user flow in Microsoft Entra ID to include a step where users must enter their invitation code.

4. **Validate Invitation Codes**:
   - Implement a validation mechanism in your backend to check the invitation code entered by the user. This can be done by creating a custom API that the user flow calls to validate the code.

### Example Implementation

#### 1. **Generate and Store Invitation Codes**:
   - Create a simple script or application to generate unique codes and store them in a database.

#### 2. **Customize User Flow**:
   - In the Microsoft Entra admin center, navigate to **Identity > External Identities > User flows**.
   - Create or edit a user flow to include a custom attribute for the invitation code.

#### 3. **Validate Invitation Codes**:
   - Create an API endpoint in your backend to validate the invitation code.
   - Example in C#:
     ```csharp
     [ApiController]
     [Route("api/[controller]")]
     public class InvitationController : ControllerBase
     {
         private readonly ApplicationDbContext _context;

         public InvitationController(ApplicationDbContext context)
         {
             _context = context;
         }

         [HttpPost("validate")]
         public IActionResult ValidateCode([FromBody] string code)
         {
             var invitation = _context.Invitations.SingleOrDefault(i => i.Code == code && !i.IsUsed);
             if (invitation == null)
             {
                 return BadRequest("Invalid or already used invitation code.");
             }

             invitation.IsUsed = true;
             _context.SaveChanges();
             return Ok();
         }
     }
     ```

#### 4. **Integrate with User Flow**:
   - Configure the user flow to call the validation API. This can be done using custom policies in Azure AD B2C or by integrating the API call in your frontend before completing the sign-up process.

### Example User Flow Customization
1. **Add Custom Attribute**:
   - Add a custom attribute for the invitation code in the user flow.

2. **Call Validation API**:
   - Modify the user flow to call the validation API with the entered invitation code. If the code is valid, proceed with the sign-up; otherwise, show an error message.

By following these steps, you can ensure that only users with a valid invitation code can sign up for your application using Microsoft Entra ID.

Would you like more detailed guidance on any specific part of this setup?

Source: Conversation with Copilot, 17-10-2024
(1) Self-service sign-up for External ID - Microsoft Entra External ID. https://learn.microsoft.com/en-us/entra/external-id/self-service-sign-up-overview.
(2) Self-service sign up for email-verified users - Microsoft Entra ID. https://learn.microsoft.com/en-us/entra/identity/users/directory-self-service-signup.
(3) Self-service password reset deep dive - Microsoft Entra ID. https://learn.microsoft.com/en-us/entra/identity/authentication/concept-sspr-howitworks.