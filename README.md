# DemoExternalLoginsApp-AspNetCore
Default Asp.Net Core 2.1 MVC application that implements external provider authentication (like FaceBook).  Configured for Docker support.

<p>
The following aritcles were referenced:
<ul>
  <li>https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/?view=aspnetcore-2.1 </li>
  <li>https://docs.microsoft.com/en-us/aspnet/core/security/authentication/social/facebook-logins?view=aspnetcore-2.1&tabs=aspnetcore2x</li>
  <li>(Azure Key Vault integration for storing Facebook App Secret) - https://docs.microsoft.com/en-us/aspnet/core/security/key-vault-configuration?view=aspnetcore-2.1&tabs=aspnetcore2x</li>
</ul>
</p>

<p>
An issue occurred in Docker for Windows where docker lost the ability to bind to locahost.  I received the error similar to this <a href="https://github.com/docker/for-win/issues/1804" target="_blank">issue</a> in GitHub.  I ended up having to run <code>netcfg -d</code> and then restarting the VM.
</p>
