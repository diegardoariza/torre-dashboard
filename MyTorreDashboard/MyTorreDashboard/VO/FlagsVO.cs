using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreJsonReader.VO
{
    public class FlagsVO
    {
        public Boolean Benefits { get; set; }
        public Boolean Canary { get; set; }
        public Boolean EnlauSource { get; set; }
        public Boolean Fake { get; set; }
        public Boolean FeatureDiscovery { get; set; }
        public Boolean FirstSignalSent { get; set; }
        public Boolean SignalsOnboardingCompleted { get; set; }
        public Boolean ImportingLinkedin { get; set; }
        public Boolean OnBoarded { get; set; }
        public Boolean Remoter { get; set; }
        public Boolean SignalsFeatureDiscovery { get; set; }
        public Boolean ImportingLinkedinRecommendations { get; set; }
        public Boolean ContactsImported { get; set; }
        public Boolean AppContractsImported { get; set; }
        public Boolean GenomeCompletionAcknowledged { get; set; }
        public Boolean CvImported { get; set; }
        public Boolean CommunityCreatedPrivate { get; set; }
        public Boolean CommunityCreatedClaimed { get; set; }
        public Boolean AutomatedMessagesFeaturedDiscovery { get; set; }
        public Boolean ExperiencesVerificationSurvey { get; set; }
        public Boolean FirstGetSignalBenefitsViewed { get; set; }
        public Boolean FirstSignalOnBoarded { get; set; }
        public Boolean MatchAndRankDisclaimerViewed { get; set; }
        public Boolean MembersBenefitsViewed { get; set; }
        public Boolean NotificationsPhrasesSarcastic { get; set; }
        public Boolean OpportunitiesBenefitsViewed { get; set; }
        public Boolean ReferredMatchUnderstood { get; set; }
        public Boolean TorreMatchAcknowledge { get; set; }
        public Boolean SignedInToOpportunities { get; set; }
        public Boolean EarlyAccess { get; set; }
        public Boolean OpportunityCrawler { get; set; }
        public Boolean OpportunityOperator { get; set; }
        public Boolean Veiled { get; set; }
        public String Features { get; set; }
        
    }
}
