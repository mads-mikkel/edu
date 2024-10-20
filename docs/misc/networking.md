**Denne opgave er lavet med hjælp fra AI. Opgaven er endnu ikke oversat til dansk. opgaven er ikke efterprøvet og kan derfor indeholde fejl og mangler.**

# Dive into Network Analysis: Building a Rust-based Packet Sniffer
## 1 Purpose and Goal
The goal of this exercise is to develop a network packet sniffer using Rust. This project will help you understand network protocols, packet capturing, and real-time data processing. By the end of this exercise, you will have a functional packet sniffer that can capture, filter, and analyze network traffic, providing real-time statistics and saving captured data to a file.
## 2 Introduction
Understanding how to capture and analyze network packets is a crucial skill for anyone involved in network security, system administration, or IT infrastructure. Packet sniffing allows you to monitor network traffic, diagnose network issues, and detect malicious activities. This skill is essential for maintaining the security and performance of modern networks.
Imagine being able to see all the data flowing through a network, like a digital detective uncovering hidden clues. Packet sniffing gives you this superpower, enabling you to peek into the packets of data that travel across networks. This ability is not just for catching cybercriminals; it’s also vital for ensuring that networks run smoothly and efficiently.
### 2.1 Real-Life Use Cases:
1.	**Network Troubleshooting**: Packet sniffers help diagnose network issues by capturing and analyzing traffic to identify bottlenecks, misconfigurations, or failures. For instance, if a company’s internal network is slow, a packet sniffer can reveal if a particular device is flooding the network with unnecessary traffic.
2.	**Security Monitoring**: Security professionals use packet sniffers to detect and analyze suspicious activities, such as unauthorized access attempts, malware communication, and data exfiltration. For example, during a cyberattack, a packet sniffer can help identify the source of the attack and the type of data being targeted.
3.	**Performance Analysis**: Packet sniffers can monitor network performance, helping to optimize bandwidth usage and improve the efficiency of networked applications. For instance, an online gaming company might use packet sniffing to ensure that their servers are handling game data efficiently, providing a smooth experience for players.
Real-Life Examples:
4.	**Wireshark**: One of the most widely used packet sniffers, Wireshark, has been instrumental in network troubleshooting and security analysis. It has helped countless organizations identify and resolve network issues. For example, a major telecommunications company used Wireshark to diagnose and fix a critical issue that was causing dropped calls for thousands of customers.
5.	**Stuxnet**: The discovery of the Stuxnet worm, which targeted industrial control systems, involved extensive packet analysis to understand its propagation and control mechanisms. This led to significant changes in how industrial networks are secured. The analysis revealed that Stuxnet was designed to sabotage Iran’s nuclear program, highlighting the importance of network security in protecting critical infrastructure.
6.	**Heartbleed Bug**: The Heartbleed vulnerability in OpenSSL was identified and analyzed using packet sniffing techniques, leading to widespread patches and improvements in SSL/TLS implementations. This vulnerability allowed attackers to read sensitive data from servers, such as passwords and encryption keys, underscoring the need for vigilant network monitoring.
7. **And remember**, with great power comes great responsibility. Use your packet-sniffing skills wisely, and always for good. Now, let’s dive into the exciting world of network analysis and start building your very own Rust-based packet sniffer!

### 2.2 Key Concepts
* Packet Sniffing: Intercepting and logging traffic that passes over a digital network.
* Network Protocols: Rules and conventions for communication between network devices, including TCP/IP.
* Concurrency: Handling multiple tasks simultaneously, crucial for real-time applications.

### 2.3 Useful Online Resources
* Articles:
    * [TCP/IP](https://network-guides.com/tcp-ip-basics/)
    * [Packet Sniffing Basics](https://www.redhat.com/en/blog/packet-sniffer-basics)
*	Videos:
    * [What is poacket Sniffing?](https://www.youtube.com/watch?v=EFcE81EiOfY)
    * [Packet Sniffing 101 - Ethical Hacking](https://www.youtube.com/watch?v=y7_77KjSvdo&t)


## 3 Exercises
### 3.1 Basic Packet Capture
* Objective: Set up the environment and capture basic network packets.
* Overview:
    1.	Install Dependencies: Ensure you have Rust installed. Add the necessary crate for packet capturing.
    2.	Select Network Interface: List available network interfaces and select one for packet capture.
    3.	Capture Packets: Write a program to capture packets from the selected network interface and print the raw packet data to the console.
    
* Detailed Explanation:
    1. Install Dependencies:
        * Use the package manager to add a crate that provides packet capturing capabilities.
        * Ensure your project is set up correctly with all necessary dependencies.
        * _Useful Fact: The pcap crate is a Rust binding for the libpcap library, which is widely used for network packet capture and analysis._
    2.	Select Network Interface:
        * Use a function to list all available network interfaces on your machine.
        *	Print the list of interfaces to the console, allowing you to choose the correct one.
    *	Select the desired interface based on its name or description.
    *	_Useful Fact: Network interfaces can include physical devices like Ethernet and Wi-Fi adapters, as well as virtual interfaces created by software._
    3.	Capture Packets:
        *	Open the selected network interface for packet capturing.
        *	Enter a loop that continuously captures packets from the network.
        *	For each captured packet, print its raw data to the console. This data will be in byte format, representing the entire packet from the Ethernet header to the payload.
        *	_Useful Fact: Capturing packets at the network interface level allows you to see all traffic passing through the interface, including traffic not intended for your machine._

### 3.2 Packet Filtering
*	Objective: Implement packet filtering to capture only specific types of packets.
*	Overview:
    1.	Apply Filter: Modify your program to apply a filter (e.g., capture only TCP packets).
    2.	Capture and Print: Capture and print only the packets that match the filter criteria.

* Detailed Explanation:
    1.	Apply Filter:
        *	Use a function to set a filter on the packet capture process.
        *	Specify the filter criteria using a filter syntax (e.g., “tcp” to capture only TCP packets).
        *	_Useful Fact: Packet filters are typically written in a domain-specific language that allows you to specify criteria such as protocol type, port number, and IP address._
    2.	Capture and Print:
        *	Continue capturing packets, but now only those that match the filter criteria will be processed.
        *	Print the filtered packets’ raw data to the console.
        *	_Useful Fact: Filtering packets at the capture level reduces the amount of data processed by your program, improving performance and focusing on relevant traffic._

### 3.3 Packet Parsing
*	Objective: Parse the captured packets to extract useful information.
*	Overview:
    1.	Add Parsing Library: Add a crate that provides packet parsing capabilities.
    2.	Parse Headers: Parse the Ethernet, IP, and TCP headers from the captured packets.
    3.	Print Parsed Information: Extract and print information such as source and destination IP addresses, and ports.
* Detailed Explanation:
    1.	Add Parsing Library:
        *	Include a crate in your project that can parse network packet headers.
        *	_Useful Fact: The etherparse crate in Rust can parse various network protocol headers, making it easier to extract meaningful data from raw packets._
    2.	Parse Headers:
        *	For each captured packet, parse the Ethernet header to extract the MAC addresses.
        *	Parse the IP header to extract the source and destination IP addresses.
        *	Parse the TCP header to extract the source and destination ports.
        o	_Useful Fact: Network packets are structured in layers, with each layer adding its own header. The Ethernet header is at the data link layer, the IP header at the network layer, and the TCP header at the transport layer._
    3.	Print Parsed Information:
        *	Print the extracted information in a readable format, such as “Source IP: X.X.X.X, Destination IP: Y.Y.Y.Y, Source Port: A, Destination Port: B”.
        *	Useful Fact: Parsing packet headers allows you to analyze network traffic patterns, identify sources and destinations, and troubleshoot network issues.