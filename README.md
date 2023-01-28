# Tanya

"Victory. Such a tempting thing. Naturally, everyone wants to savor a taste." - Tanya von Degurechaff

# Installation

## (1) Hide Process

> We'll ensure that non-root users are unable to see the `project-tanya` service.

See libprocesshider

## (2) Disable Process Tracing

We'll ensure that non-root users cannot use `ptrace` capabilities.

1. Switch to the `root` user:

```
su
```

2. Open `/etc/sysctl.d/10-ptrace.conf` with *vim*:

```
vim /etc/sysctl.d/10-ptrace.conf
```

3. Change the `kernel.yama.ptrace_scope` value to `2`:

```
kernel.yama.ptrace_scope = 2
```

4. Reboot your system:

```
reboot
```

5. Check that the `ptrace_scope` is set to `2`:

```
sysctl kernel.yama.ptrace_scope
```

See [this page for more information](https://www.kernel.org/doc/Documentation/security/Yama.txt) on process tracing.

## (3) Install .NET

We'll ensure that `project-tanya` can be compiled with *.NET*.

1. Switch to the `root` user:

```
su
```

2. Add the *Microsoft* package repositories:

* See https://docs.microsoft.com/en-us/dotnet/core/install/linux.
* Be sure to carefully follow instructions for your Linux flavor.

3. Install *.NET 6.0*:

```
apt update && apt install -y dotnet-sdk-6.0
```

## (4) Build Service

We'll build `project-tanya`, so we can register it as a service:

1. Switch to `root` user:

```
su
```

2. Open the `/root` directory: 

```
cd ~
```

3. Install dependencies:

```
apt install -y git
```

4. Clone this repository:

```
git clone https://github.com/XRadius/project-tanya
```

5. Open the `project-tanya` directory:

```
cd ~/project-tanya
```

6. Enable execution of the *build script*:

```
chmod +x service-build.sh
```

8. Run the *build script*:

```
./service-build.sh
```

## (5) Install Service

We'll install `project-tanya` as a service:

1. Open the `bin` directory:

```
cd ~/project-tanya/bin
```

2. Run the *installation script* and follow the instructions:

```
./service-install.sh
```

Once you've followed these instructions, `project-tanya` is ready for use!
