using System;
using Xunit;
using HoloalphabeticSentence;
using FluentAssertions;

namespace HoloalphabeticSentence.Tests
{
    public class HoloalphabeticSentenceTest
    {
        [Fact]
        public void Sentence_empty()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("").Should().BeFalse();
        }

        [Fact]
        public void Recognizes_a_perfect_lower_case_pangram()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("abcdefghijklmnopqrstuvwxyz").Should().BeTrue();
        }

        [Fact]
        public void HoloalphabeticSentence_with_only_lower_case()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("the quick brown fox jumps over the lazy dog").Should().BeTrue();
        }

        [Fact]
        public void Missing_character_x()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("a quick movement of the enemy will jeopardize five gunboats").Should().BeFalse();
        }

        [Fact]
        public void Another_missing_character_e_g_h()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("five boxing wizards jump quickly at it").Should().BeFalse();
        }

        [Fact]
        public void HoloalphabeticSentence_with_underscores()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("the_quick_brown_fox_jumps_over_the_lazy_dog").Should().BeTrue();
        }

        [Fact]
        public void HoloalphabeticSentence_with_numbers()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("the 1 quick brown fox jumps over the 2 lazy dogs").Should().BeTrue();
        }

        [Fact]
        public void Missing_letters_replaced_by_numbers()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("7h3 qu1ck brown fox jumps ov3r 7h3 lazy dog").Should().BeFalse();
        }

        [Fact]
        public void HoloalphabeticSentence_with_mixed_case_and_punctuation()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("\"Five quacking Zephyrs jolt my wax bed.\"").Should().BeTrue();
        }

        [Fact]
        public void Upper_and_lower_case_versions_of_the_same_character_should_not_be_counted_separately()
        {
            HoloalphabeticSentence.IsHoloalphabeticSentence("the quick brown fox jumps over with lazy FX").Should().BeFalse();
        }

    }
}
