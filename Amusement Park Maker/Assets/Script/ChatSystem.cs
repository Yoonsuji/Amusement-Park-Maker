using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChatSystem : MonoBehaviour
{
    public Image character1Image;
    public Image character2Image;
    public Text nameText;
    public Text dialogueText;
    public Image background; // ��� �̹����� ǥ���� UI Image

    private string[] dialogueLines;
    private int currentLine = 0;

    private float maxAlpha = 1.0f; // �ִ� ����
    private float minAlpha = 0.5f; // �ּ� ����

    public Sprite[] backgrounds;

    void Start()
    {
        dialogueLines = new string[]
        {
            "���: �ȳ�, �������� ģ����! �� �������Ǿƿ� ��� �ִ� ����",
            "����: ���� �������Ǿƿ� ��� �ְ�, �̸��� ������! ������ �ݰ���",
            "���: �츮�� �����شٰ� �����! �׷� �����ϰ� �츮�� ��Ȳ�� �����ٰ�",
            "����: ��������� �������Ǿƴ� ���� �����ϸ� ��ư��� �־�!",
            "���: �������忡�� ������� ������� ��ſ��� �ູ �������� �������Ǿ��� �۷ι� �� �ִ� ����Ʈ���� �� �������Ǿƿ� ��� �ֹ��� ���� �ǰ�, �Ǵ����κ��� ��ȣ����",
            "����: �ູ�������� ���� �����!! �׷��� �����ֿ� ��Ÿ�� ���� �༮���� ���� Ʈ���� �ִ� �ູ�� ���޶��带 �����Ⱦ�.",
            "���: �츮�� �� ���޶��带 �����ϱ� ���� �� ���� �������, ���������� ��û�� �ູ �������� �ʿ���",
            "����: �������ǾƸ� ���� ���̵����� ��ؼ� �������� ������� ��ſ��� ����� �� �ִ�??",
            "���: ��Ź�Ұ�!!!"
        };

        ShowNextLine();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowNextLine();
        }
    }
    void ShowNextLine()
    {
        if (currentLine < dialogueLines.Length)
        {
            string line = dialogueLines[currentLine];
            string[] parts = line.Split(':');

            if (parts.Length == 2)
            {
                string characterName = parts[0];
                string dialogue = parts[1];

                nameText.text = characterName; // �����ι� �̸��� ǥ��
                dialogueText.text = dialogue;

                if (characterName == "���")
                {
                    SetCharacterAlpha(character1Image, maxAlpha);
                    SetCharacterAlpha(character2Image, minAlpha);
                }
                else if (characterName == "����")
                {
                    SetCharacterAlpha(character1Image, minAlpha);
                    SetCharacterAlpha(character2Image, maxAlpha);
                }

                if (currentLine < backgrounds.Length)
                {
                    background.sprite = backgrounds[currentLine];
                }
            }

            currentLine++;
        }
        else
        {
            SceneManager.LoadScene("Main");
        }

        void SetCharacterAlpha(Image characterImage, float alpha)
        {
            Color color = characterImage.color;
            color.a = alpha;
            characterImage.color = color;
        }
    }
}