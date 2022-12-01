using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;

public class ViewModel : MonoBehaviour
{

    [SerializeField] private GameObject[] modelHUD;
    [SerializeField] private GameObject[] profileImage;
    [SerializeField] private TextMeshProUGUI titleUIText;
    [SerializeField] private TextMeshProUGUI descriptionUIText;
    [SerializeField] private TextMeshProUGUI profileNameUIText;

    private string[,] colleges;
    private bool isDescriptionOpen;
    

    void Start()
    {

        colleges = new string[5, 3]
        {

            { "College of Engineering and Architecture (CEA)", "Bachelor of Science in Architecture\n\n�	The Bachelor of Science in Architecture program is a five-year course that equips students with in-depth knowledge and skills to prepare them for a career in architecture, interior design, physical planning, landscaping, urban planning, or building-construction. Through our program, students will create studies to help them learn important skills in conceptualizing and planning structural designs. Their studies may have to do with the initial construction of a building, or the enlargement, renovation, remodeling, restoration or alteration of an existing structure. Furthermore, the program will equip students with knowledge in administering and supervising projects.\n\nBachelor of Science in Civil Engineering\n\n�	The Bachelor of Science in Civil Engineering program is a four-year course that teaches students the knowledge, skills, and training necessary for designing, constructing and maintaining buildings, and public infrastructure and facilities. We also develop their zest for excellence and lifelong training necessary for adapting to civil engineering trends. Graduates of the BS Engineering program must take the board exams conducted by the Professional Regulation Commission to become professionals.\n\nBachelor of Science in Electrical Engineering\n\n�	The Bachelor of Science in Electrical Engineering program is a four-year course that focuses on teaching the following to students: advance power system analysis, (including power generation, transmission distribution, and utilization) and information and communication technology. We will also teach them management skills to pave the way for a clearer path to professional growth. Finally, we will instill in them the values of efficiency, sustainability, and safety for all the projects that they will be undertaking in their career. Graduates of the BS Electrical Engineering program must take the board exams conducted by the Professional Regulation Commission to qualify as professionals.\n\nBachelor of Science in Electronic Engineering\n\n�	The PHINMA UPang BSECE program develops students into applications-oriented professionals that provide service and electronic solutions to challenging technical problems in the fields of the profession. The program continually aims to produce employable individuals with good communication skills, highly immersed in real-work scenarios through experiential learning, and ethical professionals that follows established ethical standards in the practice of the electronics engineering profession.\n\nBachelor of Science in Computer Engineering\n\n�	The Bachelor of Science in Computer Engineering program is a five-year course that provides its students with a strong foundation in science, mathematics, and engineering. The program trains students to create and deliver solutions in the field of embedded systems technology. It also teaches them how to integrate hardware with software. The goal of the program is to have its graduates employed in business that inspire lifelong learning in Computer Engineering, who are good communicators and aware of their social and ethical responsibilities as professionals.\n\nBachelor of Science in Mechanical Engineering\n\n�	The Bachelor of Science in Mechanical Engineering program focuses on teaching students the processes and system necessary for building machinery including aircrafts, spacecrafts, trains, medical equipment, and home appliances, as well as textile. We provide students with theories in chemistry and physics that will help them as they design and develop machineries that people will use. Graduates of the BS Mechanical Engineering program must take the board exams conducted by the Professional Regulation Commission to become professionals.","John T. Zamora" },
            { "College of Health Sciences (CHS)", "Bachelor of Science in Nursing\n\n�	The BS Nursing program is a four-year course where we teach students nursing concepts alongside Related Learning Experiences (RLE). Through our outcome-based curriculum, we train students to become competent through simulated clinical and active learning activities. Our program also provides an intensive nursing practicum that will make our students skilled, refined and worthy of entering the nursing profession.\n\nBachelor of Science in Medical Laboratory Science\n\n�	The Bachelor of Science in Medical Laboratory Science is a four-year program that provides knowledge in the fields of Clinical Chemistry, Hematology, Microbiology, Immunohematology, Immunology and Serology, Urinalysis, Clinical Microscopy, Parasitology, Cytology, and Histopathology. During their fourth year, students undergo an internship program in a CHED-accredited training laboratory where they rotate between sections. Graduates of the program must take the board exams conducted by the Professional Regulation Commission to qualify as registered medical technologies.\n\nBachelor of Science in Physical Therapy\n\n�	The Bachelor of Science in Physical therapy program is a four-year degree course that provides students with medical knowledge and rehabilitation training necessary for their future profession. We hone their skills through simulated clinical and active learning activities in a dynamic learning community, under an outcomes-based curriculum. Through the course�s internship program, we assign students to different CHED-accredited affiliated center where they will interact with patients that have neurological, muscoskeletal, cardiopulmonary conditions in need of rehabilitation. Graduates of the BS Physical Therapy program must take the board exams conducted by the Professional Regulation Commission to qualify as Registered Physical Therapists.\n\nBachelor of Science in Pharmacy\n\n�	The Bachelor of Science in Pharmacy is a four-year course which focuses on teaching necessary foundational knowledge for pharmaceutical product development. Through our program, we teach students on the essentials of pharmaceutical chemistry, pharmaceutics, and the life sciences. During their fourth year, we will assign students to intern in various CHED-accredited affiliated establishments to learn about the rigors of pharmacy practice. Their internship will expose them to various practice areas and prepare them for the roles they make take on after graduation. Graduates of the BS Pharmacy program must take the board exams conducted by the Professional Regulation Commission to qualify as registered Pharmacists.","Dr. Maria Teresa R. Fajardo"},
            { "College of Information Technology Education (CITE)", "Bachelor of Science in Information Technology\n\n�	The BS Information Technology program provides students with skills and knowledge needed in relevant emerging high-growth areas in the industry. Through our program, we train students with the development and management of contemporary areas such as cloud computing and applications, analysis and data science, artificial intelligence, and the Internet of Things. We use a curriculum based on inputs and guidance from practicing industry experts.","Aristotle B. Liwanag" },
            { "College of Management and Accountancy (CMA)",  "Bachelor of Science in Accountancy\n\n�	The Bachelor of Science in Accountancy program is a four-year course that prepares students for a professional career in Accountancy, particularly in Public Accounting. The program aims to guide students by providing them technical knowledge, skills and abilities required in the accountancy profession. We also help them develop the values of integrity, independence and skepticism necessary for making professional judgments. Our program uses a competency framework for professional accountants from the International Federation of Accountants, so that graduates may take certifications in Accountancy by the Philippine Professional Regulatory Commission and other international certifying bodies.\n\nBachelor of Science in Accounting Technology\n\n�	The Bachelor of Science in Accounting Information Systems program in a four-year course that provides students with skills and knowledge in business, accounting, and computer systems. Through our program, we help students develop 1) the ability to assess existing problems in, or the lack of, a business� information systems; and 2) the expertise to recommend and build a software necessary to address these needs. Our program uses a competency framework for professional accountants from the International Federation of Accountants, so that graduates are prepared to take certifications given by the Philippine Professional Regulatory Commission and other international certifying bodies.\n\nBachelor of Science in Business Administration major in Financial Management\n\n�	The Bachelor of Science in Business Administration (BSBA) program, major in Financial Management, is a Level 3 PACUCOA-accredited course. Our program is certified to provide knowledge on financial institutions and technical skills to students who want to pursue a career in banking, finance, and capital markets. Apart from developing their expertise, the program hones students to adopt an ethical outlook towards markets. Focusing on teaching regulation, good governance and the current competitive global perspective is important so that students may effectively make crucial financial decisions once they begin working.\n\nBachelor of Science in Business Administration major in Marketing Management\n\n�	The Bachelor of Science in Business Administration (BSBA) program through its various fields of specializations guides students to become competent finance, marketing, and human resource professionals. Graduates are also prepared to become successful entrepreneurs and business leaders. Through a competency-based curriculum, students are able to hone basic business skills such as financial analysis, business administration, project management, and product presentation through research and feasibility studies. We help them identify trends and developments in various business industries to prepare them ahead of the real world. We engage in partnerships with industry leaders so they can learn how to work in an actual office setting. We also develop their communication, critical thinking, and problem-solving skills. Lastly, but not the least, we teach them the values of resourcefulness, creativity, discipline and teamwork.\n\nBachelor of Science in Hospitality Management\n\n�	The Bachelor of Science in Hospitality Management is a program which trains students in a diverse set of skills necessary to Hospitality professionals. Using experiential teaching methods, we hone their skills in Housekeeping, Front Office, Food and Beverage Services, Culinary, Events Planning and Cruise Line Operations. We develop their communication skills so they can properly address the needs and preferences of guests as professionals. We also teach our students the values of cultural diversity, sensitivity and versatility needed in working with and serving guests from different cultures. Most importantly, the program provides students the opportunity to earn local and international certifications and diplomas (TESDA, American Hospitality and Lodging Education Institute, School D� Hospitality of Singapore) to make them globally-competitive.\n\nBachelor of Science in Tourism Management\n\n�	The Bachelor of Science in Tourism Management trains students in a diverse set of necessary for their future careers. We use the active learning methodology in honing students� skills in functional areas like Front Office, Events Planning, Cruise Line Operations, and Travel and Tours. We develop their communication skills so they can properly guide guests through destinations and address their concerns. We also teach our students the values of cultural diversity, sensitivity and versatility needed in touring guest from different cultures. Most importantly, we instill within them the value of our heritage and culture, so that they may best represent the country as our ambassadors. Our program provides students the chance to earn local and international certifications and diplomas (TESDA, American Hospitality and Lodging Education Institute, School D� Hospitality of Singapore) for prestigious local and global opportunities.","Teofila S. Albay" },
            { "College of Social Sciences (CSS)", "Bachelor of Arts in Communication\n\n�	The Bachelor of Arts in Communication program is a four-year course that hones students� knowledge and skill necessary for a career in media, advertising, and public relations. Our program teaches students to conduct research, plan and implement campaigns and reports. By the end of the program, students should have the mastery of digital, print, and broadcast media. We also instill the values of authenticity, and integrity which they will need as they climb the career ladder in the of communication.\n\nBachelor of Arts in Political Science\n\n�	The Bachelor of Arts in Political Science program is a four-year degree course which provides students with a background in political history and theory, government systems and institutions, political behavior, local and global governance, and public management. Our program will also give students the opportunity to study areas of international relations and comparative politics. The AB Political Science also serves a preparatory program for a law degree.\n\nBachelor of Science in Criminology\n\n�	The Bachelor of Science in Criminology program is a four-year course that provides students with knowledge and skills in forensic science, criminal jurisprudence, law enforcement, criminal investigation, and correctional administration. We train our students to be efficient and effective public safety and security while maintaining human rights. We also teach them the importance of nationalism and nation-building through protection." ,"Christopher Forayo"},

        };

        isDescriptionOpen = false;
        int model = PlayerPrefs.GetInt("model", 5);
        HandleColleges(model);

    }

    void Update()
    {

        if (SimpleInput.GetButtonDown("OnDescription"))
        {

            if (isDescriptionOpen)
            {

                isDescriptionOpen = false;
                FindObjectOfType<GameManager>().OnAnimate(false);

            }
            else
            {

                isDescriptionOpen = true;
                FindObjectOfType<GameManager>().OnAnimate(true);

            }

        }

    }

    private void HandleColleges(int _college)
    {

        titleUIText.text = colleges[_college, 0];
        descriptionUIText.text = colleges[_college, 1];
        profileNameUIText.text = colleges[_college, 0];
        profileImage[_college].SetActive(true);
        modelHUD[_college].SetActive(true);

    }

}