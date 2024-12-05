# PIP is a package manager for Python packages, or modules if you like.
import camelcase

# A package contains all the files you need for a module.
# Modules are Python code libraries you can include in your project.

# Install PIP - https://pypi.org/project/pip/

# Check if PIP is Installed - pip --version

# Download a Package - pip install <package_name>
# Once the package is installed, it is ready to use. Import the "camelcase" package into your project.
txt_camel = "hello world"
c = camelcase.CamelCase()
print(c.hump(txt_camel))

#List packages - pip list

#Uninstall package - uninstall <package_name>
