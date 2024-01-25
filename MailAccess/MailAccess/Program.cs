using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MailAccess
{
    class Program
    {
        static void Main()
        {
            string current_locaion = AppDomain.CurrentDomain.BaseDirectory;
            string input_file = "combo.txt";
            int Found = 0;
            int part = 0;
            string[] access_domins = {
  "@mail.dk", "@t-online.de", "@magenta.de", "@op.pl", "@bezeqint.net",
  "@forthnet.gr", "@graphitemedia.net", "@netvigator.com", "@prijedor.com",
  "@festival-lesdeferlantes.com", "@konto.pl", "@terra.com.br", "@coeurausourire.com",
  "@wijnenvandenberghe.be", "@cebridge.net", "@amateriaux.fr", "@onet.pl",
  "@t-email.hu", "@21cn.com", "@topnet.tn", "@online.de", "@sina.com", "@dodo.com.au",
  "@sylixgroupe.com", "@simlub.be", "@varsat.net", "@alerte.cz", "@hippodrome-beaupreau.fr",
  "@gbnetwork.eu", "@lesreunis.fr", "@xnet.hr", "@mv-hallstadt.de", "@sion.com",
  "@mx9.ttcn.ne.jp", "@mailforkids.net", "@montevideo.com.uy", "@t-online.hu",
  "@5x2.de", "@163.com", "@wemo-barbing.de", "@motorbike.cz", "@transporte-falkner.at",
  "@notariato.it", "@colba.net", "@shein.com", "@singnet.com.sg", "@onyx.dti.ne.jp",
  "@francasnormandie.fr", "@ajaykapoor.in", "@snpt.it", "@athena.is.dream.jp",
  "@hi-ho.ne.jp", "@mx3.ttcn.ne.jp", "@smashtennissainthubert.be", "@ewetel.net",
  "@aclicoop.com", "@saol.com", "@dipendentisds.info", "@20hours.it", "@medicinafutura.it",
  "@carloporta.it", "@2980.com", "@k-pro.co.kr", "@aueb.gr", "@paradeeresort.com",
  "@013net.net", "@eircom.net", "@ewe.net", "@emibou.com", "@distributel.net",
  "@cabinet-adr.tn", "@ciao-gusto.com", "@jesus.ch", "@tele2.nl", "@adriambiente.it",
  "@cissegypt.com", "@venturigiorgi.it", "@netunion.it", "@supanet.com", "@1337.no",
  "@guarulhos.sp.gov.br", "@nifty.com", "@integratorav.pl", "@r7.com", "@sina.com.cn",
  "@ofssicilia.it", "@erlenbaugh.com", "@agevola.com", "@perindpg.it", "@lantic.net",
  "@edilcontractsrl.it", "@wooow.it", "@wycdk.cn", "@cdsservice.it", "@aqua.dti2.ne.jp",
  "@numeryx.fr", "@salesspa.com", "@stofanet.dk", "@agent-network.com", "@ldsubmissions.com",
  "@globalnet.hr","@corintea.it", "@makspa.it", "@intellidom.fr",
  "@renaultretail.it", "@btvm.ne.jp", "@adres.pl", "@britishschool.eu", "@inmail.sk",
  "@netcom-mail.de", "@albertcarpets.com", "@osnanet.de", "@ucr.ac.cr", "@eresmas.com",
  "@aliyun.com", "@hu.inter.net", "@upsrtc.com", "@nordnet.fr", "@chowsangsang.com",
  "@webstorm.co.za", "@motamici.it", "@craisardegna.com", "@4zskolin.cz", "@gyaschool.com",
  "@xposta.it", "@cytanet.com.cy", "@hostprofis.at", "@futuria.be", "@tcn-catv.ne.jp",
  "@simnet.is", "@euromail.hu", "@ipsg-eg.com", "@istitutomedici.it", "@gamecubepro.com",
  "@crivarese.it", "@associazionemetamorfosi.com", "@genopro.com", "@trusty-hk.com",
  "@mapache.co.cr", "@odcec.napoli.it", "@blic.net", "@investeco.net", "@arimoc.fr",
  "@vip.hr", "@visualchina.com", "@perform-agencement-83.fr", "@mnet-online.de",
  "@orcon.net", "@u-s-s-enterprise.com", "@jeuxcasinomobile.net", "@rilateverde.it",
  "@ufacom.ru", "@noipervoi.org", "@casolutions.it", "@enersystems.it", "@scrummy.pl",
  "@nrgweb.it", "@hkstar.com", "@astcgroup.com", "@comanchero.org", "@emmegi.com",
  "@datenpower.de", "@netcabo.pt", "@tpnet.pl", "@lycos.com", "@andercos.com",
  "@m-erreni.it", "@gryzo.cz", "@monogramsplus.net", "@myriades.fr", "@rolmail.net",
  "@shnet.co.il", "@insitel.com", "@beotel.net", "@cyberserve.net", "@upcmail.cz",
  "@skyrme.com", "@nesse.cz", "@hetnet.nl", "@jubii.dk", "@planet.nl", "@live.dk",
  "@norlys.dk", "@orange.nl", "@versatel.nl", "@wanadoo.nl", "@tiscali.dk", "@ziggo.nl",
  "@chello.nl", "@quicknet.nl", "@home.nl", "@solcon.nl", "@online.nl", "@zonnet.nl",
  "@casema.nl", "@hetnet.nl", "@e-domotique.com", "@home.nl", "@ezorg.nl", "@worldonline.nl",
  "@caiway.nl", "@freeler.nl", "@kpnmail.nl", "@noknok.nl", "@acorn.nl", "@fiberworld.nl",
  "@interactiveproduct.nl", "@adsl1.nl", "@adsl2.nl", "@adsl4.nl", "@adsl6.nl", "@adsl8.nl",
  "@adsl10.nl", "@adsl12.nl", "@adsl14.nl", "@adsl16.nl", "@adsl18.nl", "@adsl20.nl",
  "@adsl22.nl", "@adsl24.nl", "@adsl26.nl", "@adsl28.nl", "@adsl30.nl", "@adsl32.nl",
  "@adsl34.nl", "@adsl36.nl", "@adsl38.nl", "@adsl40.nl", "@adsl42.nl", "@adsl44.nl",
  "@adsl46.nl", "@adsl48.nl", "@adsl50.nl", "@adsl52.nl", "@adsl54.nl", "@adsl56.nl",
  "@adsl58.nl", "@adsl60.nl", "@adsl62.nl", "@adsl64.nl", "@adsl66.nl", "@adsl68.nl",
  "@adsl70.nl", "@adsl72.nl", "@adsl74.nl", "@adsl76.nl", "@adsl78.nl", "@adsl80.nl",
  "@adsl82.nl", "@adsl84.nl", "@adsl86.nl", "@adsl88.nl", "@adsl90.nl", "@adsl92.nl",
  "@adsl94.nl", "@adsl96.nl", "@adsl98.nl", "@adsl100.nl", "@adsl102.nl", "@adsl104.nl",
  "@adsl106.nl", "@adsl108.nl", "@adsl110.nl", "@adsl112.nl", "@adsl114.nl", "@adsl116.nl",
  "@adsl118.nl", "@adsl120.nl", "@adsl122.nl", "@adsl124.nl", "@adsl126.nl", "@adsl128.nl",
  "@adsl130.nl", "@adsl132.nl", "@adsl134.nl", "@adsl136.nl", "@adsl138.nl", "@adsl140.nl",
  "@adsl142.nl", "@adsl144.nl", "@adsl146.nl", "@adsl148.nl", "@adsl150.nl", "@adsl152.nl",
  "@adsl154.nl", "@adsl156.nl", "@adsl158.nl", "@adsl160.nl", "@adsl162.nl", "@adsl164.nl",
  "@adsl166.nl", "@adsl168.nl", "@adsl170.nl", "@adsl172.nl", "@adsl174.nl", "@adsl176.nl",
  "@adsl178.nl", "@adsl180.nl", "@adsl182.nl", "@adsl184.nl", "@adsl186.nl", "@adsl188.nl",
  "@adsl190.nl", "@adsl192.nl", "@adsl194.nl", "@adsl196.nl", "@adsl198.nl", "@adsl200.nl"
            };
            var file_search = Path.Combine(current_locaion, input_file);
            Console.ForegroundColor = ConsoleColor.Green;
            banner();
            Console.Title = "MailHunty by @SaidosHits";
            if (!File.Exists(file_search))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Sorry the combo.txt is not found !");
                Console.ReadKey();
                return;
            }
            else
            {
                int file_lenght = File.ReadAllLines(file_search).Length;
         
                if (file_lenght == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Sorry the combo.txt is empty :) ");
                    Console.ReadKey();
                    return;
                }

            }
            Console.WriteLine(" Please press any key to Start");
            Console.ReadKey();
            Console.Clear();

            var Current_time = DateTime.Now;
            string date_form  = string.Format("{0:[hh:mm:ss] [dd/MM/yyyy]}", Current_time) ;
            HashSet<string> emails = new HashSet<string> {$"@SaidosHits {date_form}\n\n            [Result]        \n"};
            int file_length = File.ReadAllLines(file_search).Length;
            using (StreamReader read_input = File.OpenText(file_search))
            {
                string line;
                while((line = read_input.ReadLine()) != null)
                {
                    part++;
                    int precent = (int)(((double)part / file_length) * 100);
                    Console.Title = $"MailHunty @SaidosHits | Combo:[{file_length}/{part}] Precent[{precent}%] Found:[{Found}]";
                     foreach(string domin in access_domins)
                    {
                        if (line.Contains(domin))
                        {
                            Found++;
                            emails.Add(line);
                        }
                    }
                    
                }
                string folder_name = string.Format("Result {0:[dd.MM.yyyy] [hh.mm.ss]}", Current_time);
                Directory.CreateDirectory(folder_name);
                if(Found >= 1000)
                {
                    string save_file = Path.Combine(folder_name, $"x{Found}k_@SaidosHits.txt");
                    using (StreamWriter write_output = new StreamWriter(save_file))
                    {
                        foreach (string email in emails)
                        {
                            write_output.WriteLine(email);

                        }
                    }
                }
                else
                {
                    string save_file = Path.Combine(folder_name, $"x{Found}_@SaidosHits.txt");
                    using (StreamWriter write_output = new StreamWriter(save_file))
                    {
                        foreach (string email in emails)
                        {
                            write_output.WriteLine(email);

                        }
                    }
                }
                banner();
                Console.WriteLine(" Work Done !");
                Console.ReadKey();

            }

        }
        static void banner()
        {
            Console.WriteLine(@"
               ___    ,---.       .=-.-.         ,--.-,,-,--,             .-._        ,--.--------.                
        .-._ .'=.'\ .--.'  \     /==/_ / _.-.   /==/  /|=|  |.--.-. .-.-./==/ \  .-._/==/,  -   , -\,--.-.  .-,--. 
       /==/ \|==|  |\==\-/\ \   |==|, |.-,.'|   |==|_ ||=|, /==/ -|/=/  ||==|, \/ /, |==\.-.  - ,-./==/- / /=/_ /  
       |==|,|  / - |/==/-|_\ |  |==|  |==|, |   |==| ,|/=| _|==| ,||=| -||==|-  \|  | `--`\==\- \  \==\, \/=/. /   
       |==|  \/  , |\==\,   - \ |==|- |==|- |   |==|- `-' _ |==|- | =/  ||==| ,  | -|      \==\_ \  \==\  \/ -/    
       |==|- ,   _ |/==/ -   ,| |==| ,|==|, |   |==|  _     |==|,  \/ - ||==| -   _ |      |==|- |   |==|  ,_/     
       |==| _ /\   /==/-  /\ - \|==|- |==|- `-._|==|   .-. ,\==|-   ,   /|==|  /\ , |      |==|, |   \==\-, /      
       /==/  / / , |==\ _.\=\.-'/==/. /==/ - , ,/==/, //=/  /==/ , _  .' /==/, | |- |      /==/ -/   /==/._/       
       `--`./  `--` `--`        `--`-``--`-----'`--`-' `-`--`--`..---'   `--`./  `--`      `--`--`   `--`-`        
                                     @SaidosHits


");
        }
    }
}
